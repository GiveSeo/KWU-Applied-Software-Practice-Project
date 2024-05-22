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
    public class User : Packet
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
        public User(string id, string password)
        {
            this.name = string.Empty;
            this.id = id;
            this.password = password;
            cur_teamids = null;
        }
        public string GetId() {  return id; }
        public string GetPassword() { return password; }
        public string GetName() { return name; }
        public List<int> GetTeamIds() { return cur_teamids; }
        public void AddTeamId(int tid) { cur_teamids.Add(tid); }
        public void RemoveTeamId(int tid)
        {
            if (cur_teamids.Count == 0)
                return;
            cur_teamids.Remove(tid);
        }
        public void ChangeName(string name) { this.name = name; }
        public void ChangeID(string id) { this.id = id; }
        public void ChangePassword(string pw) { this.password = pw; }
    }
}
