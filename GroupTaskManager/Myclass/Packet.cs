using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Myclass
{
    [Serializable]
    public class Packet
    {
        public int length;
        public int type;
        public Packet()
        {
            length = 0;
            type = 0;
        }
        public static byte[] serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(4096);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }
        public static Object deserialize(byte[] b)
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
