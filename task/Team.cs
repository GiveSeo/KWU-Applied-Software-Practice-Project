using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myclass
{
    [Serializable]
    public class Team : Packet
    {
        public int instruction;// 1시 team 추가, 2시 team edit, 3시 team delete
        public int id; 
        private User admin;
        private int people;
        private string project;
        private List<string> goals;
        public Team(int i, User u, string p)
        {
            id = i;
            admin = u;
            people = 1;
            project = p;
            goals = new List<string>();
        }
    }
}
