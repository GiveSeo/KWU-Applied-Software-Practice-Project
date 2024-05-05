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
        static List<User> userlist = new List<User>();
        static List<User> cur_userlist = new List<User>();
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
                Console.WriteLine("send [{0}]", temp);
                if (temp.Equals("ss"))
                    cur_userlist.Add(uu);
                Console.WriteLine("{0} connected", uu.get_name());
                show_cur_userlist();
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
           while (true) { }
        }
    }
}
