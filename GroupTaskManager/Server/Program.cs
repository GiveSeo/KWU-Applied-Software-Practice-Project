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
        static List<(TcpClient client, string name)> chatClients = new List<(TcpClient, string)>(); // 채팅 중인 유저 리스트

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

        static void chat()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 13002);
            listener.Start();
            Console.WriteLine("chat thread start");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
                string name = reader.ReadLine();
                chatClients.Add((client, name));
                Console.WriteLine("new chat client connected: " + name);
                Thread chatThread = new Thread(() => handleChatClient(client));
                chatThread.Start();
            }
        }

        static void handleChatClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            while (true)
            {
                string message = reader.ReadLine();
                string whisper = reader.ReadLine();
                if (message == null) break;
                Console.WriteLine("received message: " + message);
                if (string.IsNullOrEmpty(whisper))
                {
                    broadcastMessage(message, client); // 메시지를 모든 클라이언트에게 전송
                }
                else
                {
                    WhisperMessage(message, client, whisper);
                }
            }
            chatClients.RemoveAll(c => c.client == client);
            client.Close();
        }

        // 메시지를 모든 클라이언트에게 전송하는 메소드
        static void broadcastMessage(string message, TcpClient sender)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            foreach (var (client, _) in chatClients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        static void WhisperMessage(string message, TcpClient sender, string whisper)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(whisper + "<-" + message);
            foreach (var (client, username) in chatClients)
            {
                if (username.Equals(whisper, StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        NetworkStream stream1 = client.GetStream();
                        stream1.Write(buffer, 0, buffer.Length);
                        NetworkStream stream2 = sender.GetStream();
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
