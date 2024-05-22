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
        private int id; 
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

        public int GetID() { return id; }
        public User GetAdmin() { return admin; }
        public int GetPeople() { return people;}
        public string GetProject() { return project;}

        public void AddGoal(string s) { goals.Add(s);}
        public void RemoveGoal(string s)
        {
            if (goals.Count == 0)
                return;
            goals.Remove(s);
        }

        public void ChangeAdmin(User u) { admin = u; }
        public void ChangePeople(int i) { people = i; }
        public void AddPeople(int i ) { people += i; }
        public void RemovePeople(int i) { people -= i; }
    }
}
