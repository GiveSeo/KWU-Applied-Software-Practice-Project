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
using ClassLibrary1;

namespace Server
{
    internal class Program
    {
        static List<User> users = new List<User>();
        static List<Team> teams = new List<Team>();
        static List<(User, TcpClient)> chatClient = new List<(User, TcpClient)>();
        static List<User> cur_users = new List<User>();
        static byte[] readbuffer = new byte[Packet.length];
        static byte[] writebuffer = new byte[Packet.length];

        static void LoadUser()
        {
            FileStream stream = File.OpenRead("User.txt");
            BinaryFormatter bf = new BinaryFormatter();
            users = (List<User>)bf.Deserialize(stream);
            stream.Close();
        }

        static void SaveUser()
        {
            FileStream stream = File.OpenWrite("User.txt");
            BinaryFormatter bf = new BinaryFormatter();
            List<User> u = users.ToList();
            bf.Serialize(stream, u);
            stream.Close();
        }

        static void LoadTeam()
        {
            FileStream stream = File.OpenRead("Team.txt");
            BinaryFormatter bf = new BinaryFormatter();
            teams = (List<Team>)bf.Deserialize(stream);
            stream.Close();
        }

        static void SaveTeam()
        {
            FileStream stream = File.OpenWrite("Team.txt");
            BinaryFormatter bf = new BinaryFormatter();
            List<Team> t = teams.ToList();
            bf.Serialize(stream, t);
            stream.Close();
        }

        static void InitList()
        {
            User u1 = new User("이준서", "GiveSeo", "1111");
            User u2 = new User("남기현", "gihyeonnam", "1111");
            User u3 = new User("전병은", "priesthief", "1111");
            User u4 = new User("이재훈", "ijh1382", "1111");
            Team t = new Team(0, u1, "응소실 9조");
            t.AddMemid(u2.GetId());
            t.AddMemid(u3.GetId());
            t.AddMemid(u4.GetId());

            u1.AddTeamId(0);
            u2.AddTeamId(0);
            u3.AddTeamId(0);
            u4.AddTeamId(0);
            t.ChangePeople(4);
            t.AddGoal(new Tuple<string,DateTime>("팀플 끝내기",DateTime.Now));
            teams.Add(t);
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            FileStream stream = File.OpenWrite("Team.txt");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, teams);
            stream.Close();
            stream = File.OpenWrite("User.txt");
            bf.Serialize(stream, users);
            stream.Close();
        }

        static void AfterConnect(Object o)
        {
            TcpClient client = (TcpClient)o;
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            while (true)
            {
                if (!client.Connected)
                    return;
                try
                {
                    stream.Read(readbuffer, 0, Packet.length);
                    Packet p = (Packet)Packet.Deserialize(readbuffer);
                    switch (p.type)
                    {
                        case PacketType.LOGOUT:
                            Packet logout = new Packet(PacketType.OK);
                            writebuffer = Packet.Serialize(logout);
                            stream.Write(writebuffer, 0, writebuffer.Length);
                            stream.Flush();
                            stream.Close();
                            chatClient.RemoveAll(item => item.Item2 == client);
                            client.Close();
                            Console.WriteLine("연결 종료");
                            return;
                        case PacketType.SIGNUP:
                            User signup_user = (User)p;
                            foreach (User user in users)
                            {
                                if (signup_user.GetName() == user.GetName() || signup_user.GetId() == user.GetId())
                                {
                                    Packet fail = new Packet(PacketType.NOTHING);
                                    writebuffer = Packet.Serialize(fail);
                                    stream.Write(writebuffer, 0, writebuffer.Length);
                                    stream.Flush();
                                    stream.Close();
                                    client.Close();
                                    Console.WriteLine("회원가입 실패");
                                    return;
                                }
                            }
                            users.Add(signup_user);
                            SaveUser();
                            Packet ok = new Packet(PacketType.OK);
                            writebuffer = Packet.Serialize(ok);
                            stream.Write(writebuffer, 0, writebuffer.Length);
                            stream.Flush();
                            stream.Close();
                            client.Close();
                            Console.WriteLine("회원가입 완료");
                            return;
                        case PacketType.LOGIN:
                            User login_user = (User)p;
                            User check_user = users.Find(x => x.GetId() == login_user.GetId() && x.GetPassword() == login_user.GetPassword());
                            foreach (User cur_user in cur_users)
                            {
                                if (check_user.GetId() == login_user.GetId())
                                {
                                    check_user = null;
                                    break;
                                }
                            }
                            if (check_user != null)
                            {
                                check_user.type = PacketType.OK;
                                writebuffer = Packet.Serialize(check_user);
                                stream.Write(writebuffer, 0, writebuffer.Length);
                                stream.Flush();
                                writebuffer = Packet.Serialize(users.ToList<User>());
                                stream.Write(writebuffer, 0, writebuffer.Length);
                                stream.Flush();
                                stream.Read(readbuffer, 0, readbuffer.Length);
                                Packet pp = (Packet)Packet.Deserialize(readbuffer);
                                if (pp.type == PacketType.OK)
                                {
                                    writebuffer = Packet.Serialize(teams.ToList<Team>());
                                    stream.Write(writebuffer, 0, writebuffer.Length);
                                    stream.Flush();
                                }
                                cur_users.Add(check_user);
                                chatClient.Add((check_user, client));
                                Console.WriteLine("로그인 완료");
                                break;
                            }
                            else
                            {
                                User fail = new User(null, null);
                                fail.type = PacketType.NOTHING;
                                writebuffer = Packet.Serialize(fail);
                                stream.Write(writebuffer, 0, writebuffer.Length);
                                stream.Flush();
                                stream.Close();
                                client.Close();
                                Console.WriteLine("로그인 실패");
                                return;
                            }
                        case PacketType.ADD:
                            Team new_team = (Team)p;
                            teams.Add(new_team);
                            SaveTeam();
                            ok = new Packet(PacketType.OK);
                            writebuffer = Packet.Serialize(ok);
                            stream.Write(writebuffer, 0, writebuffer.Length);
                            stream.Flush();
                            Console.WriteLine("팀 추가 완료");
                            break;
                        case PacketType.EDIT:
                            Team team = (Team)p;
                            for(int i = teams.Count - 1; i >= 0; i--)
                            {
                                if(team.GetID() == teams[i].GetID())
                                    teams.RemoveAt(i);
                            }
                            teams.Add(team);
                            SaveTeam();
                            ok = new Packet(PacketType.OK);
                            writebuffer = Packet.Serialize(ok);
                            stream.Write(writebuffer, 0, writebuffer.Length);
                            stream.Flush();
                            Console.WriteLine("팀 수정 완료");
                            break;
                        case PacketType.DELETE:
                            Team del_team = (Team)p;
                            for (int i = teams.Count - 1; i >= 0; i--)
                            {
                                if (del_team.GetID() == teams[i].GetID())
                                    teams.RemoveAt(i);
                            }
                            SaveTeam();
                            ok = new Packet(PacketType.OK);
                            writebuffer = Packet.Serialize(ok);
                            stream.Write(writebuffer, 0, writebuffer.Length);
                            stream.Flush();
                            Console.WriteLine("팀 삭제 완료");
                            break;
                        case PacketType.CHAT_EVERY:
                            Chat mes = (Chat)p;
                            writebuffer = Packet.Serialize(mes);
                            foreach (var (User, Tcpclient) in chatClient)
                            {
                                NetworkStream s = Tcpclient.GetStream();
                                s.Write(writebuffer,0, writebuffer.Length);
                                Console.WriteLine("전체 메세지 전송 완료");
                            }
                            Console.WriteLine("전체 메세지 전송 완료");
                                break;
                        case PacketType.CHAT_WISPHER:
                            Chat mes_whs = (Chat)p;
                            writebuffer = Packet.Serialize(mes_whs);
                            foreach (var (U, Tcpclient) in chatClient)
                            {
                                if (U.GetId() == mes_whs.GetWhispher_id())
                                {
                                    NetworkStream s = Tcpclient.GetStream();
                                    s.Write(writebuffer, 0, writebuffer.Length);
                                    break;
                                }
                            }
                            Console.WriteLine("개인 메세지 전송 완료");
                            break;
                        case PacketType.CHAT_TEAM: // 팀 메시지 전송 패킷
                            Chat mes_team = (Chat)p;
                            writebuffer = Packet.Serialize(mes_team);
                            int team_id = mes_team.GetTeam_id();
                            foreach (var (U, Tcpclient) in chatClient)
                            {
                                List<int> tlist = U.GetTeamIds();
                                foreach (int tid in tlist)
                                {
                                    if (tid == team_id)
                                    {
                                        NetworkStream s = Tcpclient.GetStream();
                                        s.Write(writebuffer, 0, writebuffer.Length);
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("팀 메세지 전송 완료");
                            break;
                        default:
                            break;
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("연결 끊어짐");
                    stream.Close();
                    client.Close();
                    return;
                }
                catch (SocketException e)
                {
                    Console.WriteLine("연결 끊어짐");
                    stream.Close();
                    client.Close();
                    return;
                }
                catch (ObjectDisposedException e)
                {
                    Console.WriteLine("삭제된 Object에 접근함");
                    stream.Close();
                    client.Close();
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0}으로 인해 현재 스레드를 종료합니다...", e.ToString());
                    stream.Close();
                    client.Close();
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            InitList();
            LoadTeam();
            LoadUser();
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 13000);
            Console.WriteLine("!서버 실행!");
            listener.Start();
            Console.WriteLine("연결 대기 중...");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("{0} 연결됨", client.ToString());
                Thread t = new Thread(AfterConnect);
                t.Start(client);
            }
        }
    }
}