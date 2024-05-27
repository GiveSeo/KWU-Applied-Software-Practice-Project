using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Myclass;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Server
{
    internal class Program
    {
        static List<User> userlist = new List<User>();
        static List<User> cur_userlist = new List<User>();
        static List<(TcpClient client, User user)> chatClients = new List<(TcpClient, User)>(); // 채팅 중인 유저 리스트

        static void load_userlist()
        {
            StreamReader stream = new StreamReader("users.txt");
            while (!stream.EndOfStream) 
            {
                string[] ss = stream.ReadLine().Split(',');
                string name = ss[0];
                string id = ss[1];
                string pw = ss[2];
                User u = new User(name, id, pw);
                userlist.Add(u);
            }
            stream.Close();
        }

        static void show_userlist()
        {
            Console.WriteLine("///all userlist///");
            foreach (User u in userlist)
                Console.WriteLine(u.get_all());
            Console.WriteLine("//////////////////");
        }

        static void show_cur_userlist()
        {
            Console.WriteLine("///current userlist///");
            foreach (User u in cur_userlist)
                Console.WriteLine(u.get_all());
            Console.WriteLine("/////////////////////");
        }

        static void signup()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 13000);
            listener.Start();
            Console.WriteLine("sign up thread start");
            while (true) 
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("someone is trying to sign up");
                NetworkStream stream = client.GetStream();
                StreamReader client_reader = new StreamReader(stream);
                string s = client_reader.ReadLine();
                Console.WriteLine("received [{0}]", s);
                StreamWriter file_writer = new StreamWriter("users.txt", true);
                file_writer.WriteLine(s);
                Console.WriteLine("saved [{0}]", s);
                file_writer.Close();
                client_reader.Close();
                stream.Close();
                client.Close();
                string[] ss = s.Split(',');
                User u = new User(ss[0], ss[1], ss[2]);
                userlist.Add(u);
                show_userlist();
            }
        }

        static void login()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 13001);
            listener.Start();
            Console.WriteLine("login thread start");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("someone is trying to log in");
                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream);
                string s = reader.ReadLine();
                Console.WriteLine("received [{0}]", s);
                string[] ss = s.Split(',');
                string temp = "//";
                User uu = null;
                foreach(User u in userlist)
                {
                    if (ss[0].Equals(u.get_id()))
                    {
                        if (ss[1].Equals(u.get_password()))
                        {
                            temp = "ss";
                            uu = u;
                        }
                    }
                }
                writer.WriteLine(temp);
                writer.Flush();
                writer.WriteLine(uu.get_name());
                writer.Flush();
                Console.WriteLine("send [{0}]", temp);
                if (temp.Equals("ss"))
                    cur_userlist.Add(uu);
                Console.WriteLine("{0} connected", uu.get_name());
                show_cur_userlist();
            }
        }

        static void chat() // 채팅 서버 스레드 함수
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 13002);
            listener.Start();
            Console.WriteLine("chat thread start");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient(); // 클라이언트 기다림
                NetworkStream stream = client.GetStream(); // 클라이언트 스트림 설정
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
                string id = reader.ReadLine(); // 클라이언트 사용자의 id 받음
                string pw = reader.ReadLine(); // 클라이언트 사용자의 pw 받음
                User uu = null;
                foreach (User u in cur_userlist)
                {
                    if (id.Equals(u.get_id()))
                    {
                        if (pw.Equals(u.get_password()))
                        {
                            uu = u;
                        }
                    }
                }
                chatClients.Add((client, uu)); // 채팅 중인 사용자 목록에 추가
                Console.WriteLine("new chat client connected: " + uu.get_name());
                Thread chatThread = new Thread(() => handleChatClient(client));
                chatThread.Start(); // 클라이언트 채팅 핸들러 시작
            }
        }

        static void handleChatClient(TcpClient client) // 채팅 핸들러 함수
        {
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            while (true)
            {
                string message = reader.ReadLine(); // 클라이언트에게 메시지 받음
                string whisper = reader.ReadLine(); // 클라이언트에게 귓속말 상대 받음
                string team_id = reader.ReadLine(); // 클라이언트에게 팀 아이디 받음
                if (message == null) break;
                Console.WriteLine("received message: " + message);
                if (string.IsNullOrEmpty(whisper) && string.IsNullOrEmpty(team_id)) // 귓속말 상대와 팀이 없으면
                {
                    broadcastMessage(message, client); // 메시지를 모든 클라이언트에게 전송
                }
                else if (!string.IsNullOrEmpty(team_id) && string.IsNullOrEmpty(whisper)) // 팀 아이디만 있다면
                {
                    try
                    {
                        int number = Convert.ToInt32(team_id);
                        TeamMessage(message, client, number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("유효한 정수 형식이 아닙니다.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("정수 범위를 초과했습니다.");
                    }
                }
                else if(string.IsNullOrEmpty(team_id) && !string.IsNullOrEmpty(whisper))// 귓속말 상대만 있다면
                {
                    WhisperMessage(message, client, whisper); // 메시지를 귓속말 상대에게만 전송
                }
            }
            chatClients.RemoveAll(c => c.client == client);
            client.Close();
        }

        // 메시지를 모든 클라이언트에게 전송하는 메소드
        static void broadcastMessage(string message, TcpClient sender)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            foreach (var (client, _) in chatClients) // 리스트의 각 클라이언트 마다
            {
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length); // 메시지 전송
            }
        }

        // 메시지를 귓속말 상대에게만 전송하는 메소드
        static void WhisperMessage(string message, TcpClient sender, string whisper)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(whisper + "<-" + message);
            foreach (var (client, user) in chatClients) // 이름 비교로 상대를 탐색
            {
                string username = user.get_name();
                if (username.Equals(whisper, StringComparison.OrdinalIgnoreCase)) // 찾으면 전송
                {
                    try // 둘에게만 메시지가 다시 전송됨
                    {
                        NetworkStream stream1 = client.GetStream(); // 귓속말 상대
                        stream1.Write(buffer, 0, buffer.Length);
                        NetworkStream stream2 = sender.GetStream(); // 메시지 송신자
                        stream2.Write(buffer, 0, buffer.Length);
                        Console.WriteLine($"Whispered to {username}: {message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error sending whisper to {username}: {ex.Message}");
                    }
                }
            }
        }

        // 같은 팀에게만 메시지를 전달하는 메소드
        static void TeamMessage(string message, TcpClient sender, int team_id)
        {
           string tid = team_id.ToString();
            byte[] buffer = Encoding.UTF8.GetBytes(tid + "<-" + message);
            foreach (var (client, user) in chatClients) // 유저마다 팀에 속해 있나 확인
            {
                List<int> teamlist = user.get_teamids();
                if (teamlist.Contains(team_id)) // 팀에 있으면 전송
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length); // 메시지 전송
                }
            }
        }


        static void Main(string[] args)
        {
           load_userlist();
           show_userlist();
           Thread signup_thread = new Thread(signup);
           signup_thread.Start();
           Thread login_thread = new Thread(login);
           login_thread.Start();
            Thread chat_thread = new Thread(chat);
            chat_thread.Start();
            while (true) { }
        }
    }
}
