using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassLibrary
{
    [Serializable]
    public class Members
    {
        public string id;//멤버 id
        public string password;//멤버 password
        public List<string> belongPrjId;//이 멤버가 속해있는 project id
        public Members(string id, string password, List<string> belongPrjId)
        {
            this.id = id;
            this.password = password;
            this.belongPrjId = belongPrjId;
        }
    }
    [Serializable]
    public class Projects
    {
        public string ProjectId;
        public string adminId;
        public Dictionary<string,bool> id;//속해있는 구성원 id, bool형은 관리자면 true, 아니면 false; 
        public Dictionary<string, List<(string, bool)>> goalsByMemberId;//id와 그 id에게 부여된 목표 list, 달성 여부는 bool
        public Projects() { }
    }
    public enum PacketType
    {
        멤버=0,프로젝트
    }
    public enum PacketSendERROR
    {
        정상 =0,에러
    }
    [Serializable]
    public class Packet
    {
        public int Length;
        public int Type;
        public Packet()
        {
            this.Length = 0;
            this.Type = 1;
        }

        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms,o);
            return ms.ToArray();

        }
        public static Object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach(byte b in bt)
            {
                ms.WriteByte(b);
            }
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }
    [Serializable]
    public class Member : Packet
    {
        public Members m;
        public Member()
        {
            m = new Members(null,null,null);
            m.id = null;
            m.password = null;
        }
    }
    [Serializable]
    public class Project : Packet
    {
        public List<Projects> m;
        public Project() { 
        m = new List<Projects>();
        }
    }
}
