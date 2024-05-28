using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Myclass
{
    public enum PacketType : int
    {
        NOTHING = 0,
        SIGNUP,
        LOGIN,
        LOGOUT,
        OK,
        EDIT
    }

    [Serializable]
    public class Packet
    {
        public static int length = 4096;
        public PacketType type = PacketType.NOTHING;
        public Packet() { }
        public Packet(PacketType type)
        {
            this.type = type;
        }

        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(4096);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }
        public static Object Deserialize(byte[] b)
        {
            MemoryStream ms = new MemoryStream(4096);
            foreach (byte bb in b)
                ms.WriteByte(bb);
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object o = bf.Deserialize(ms);
            ms.Close();
            return o;
        }
    }
}