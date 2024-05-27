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
    public class User
    {
        private string name;
        private string id;
        private string password;
        private List<int> cur_teamids;
        public User(string name, string id, string password)
        {
            this.name = name;
            this.id = id;
            this.password = password;
            cur_teamids = new List<int>(); ;
        }
        public string get_id() {  return id; }
        public string get_password() { return password; }
        public string get_name() { return name; }
        public string get_all() { return name + "," + id + ',' + password; }
        public List<int> get_teamids() { return cur_teamids; } // 속한 팀 리스트 불러옴
    }
}
