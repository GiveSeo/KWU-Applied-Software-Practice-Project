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

namespace Server
{
    internal class Program
    {
        static List<User> users = new List<User>();
        static List<User> cur_users = new List<User>();
        static List<Team> teams = new List<Team>();
        static byte[] readbuffer = new byte[Packet.length];
        static byte[] writebuffer = new byte[Packet.length];

        static void ReadUser()
        {
            FileStream stream = File.OpenRead("User.txt");
            BinaryFormatter bf = new BinaryFormatter();
            User[] uu = (User[])bf.Deserialize(stream);
            users = uu.OfType<User>().ToList();
            stream.Close();
        }

        static void ReadTeam()
        {
            FileStream stream = File.OpenRead("Team.txt");
            BinaryFormatter bf = new BinaryFormatter();
            Team[] tt = (Team[])bf.Deserialize(stream);
            teams = tt.OfType<Team>().ToList();
            stream.Close();
        }
        static void Main(string[] args)
        {
            ReadUser();
            ReadTeam();
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 13000);
            Console.WriteLine("!서버 실행!");
            listener.Start();
            Console.WriteLine("연결 대기 중...");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                Console.WriteLine("{0} 연결됨", client.ToString());
                stream.Read(readbuffer, 0, Packet.length);
                Packet p = (Packet)Packet.Deserialize(readbuffer);
                switch (p.type)
                {
                    case PacketType.SIGNUP:
                        User signup_user = (User)p;
                        users.Add(signup_user);
                        Packet signup_packet = new Packet();
                        signup_packet.type = PacketType.OK;
                        writebuffer = Packet.Serialize(signup_packet);
                        stream.Write(writebuffer, 0, writebuffer.Length);
                        stream.Flush();
                        break;
                    case PacketType.LOGIN:
                        User login_user = (User)p;
                        User check_user = users.Find(x => x.get_id() == login_user.get_id() && x.get_password() == login_user.get_password());
                        if (check_user != null)
                        {
                            check_user.type = PacketType.OK;
                            writebuffer = Packet.Serialize(check_user);
                            stream.Write(writebuffer, 0, writebuffer.Length);
                            stream.Flush();
                        }
                        else
                        {
                            Packet fail_packet = new Packet();
                            fail_packet.type = PacketType.NOTHING;
                            writebuffer = Packet.Serialize(fail_packet);
                            stream.Write(writebuffer, 0, writebuffer.Length);
                            stream.Flush();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
