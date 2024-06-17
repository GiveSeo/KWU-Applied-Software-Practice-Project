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
        private List<string> memid;
        private List<Tuple<string,DateTime>> goals;
        public List<bool> goals_achieve;
        public Team(int i, User u, string p)
        {
            id = i;
            admin = u;
            people = 1;
            project = p;
            memid= new List<string>();
            goals = new List<Tuple<string, DateTime>>();
            goals_achieve = new List<bool>();
        }

        public Team(int i,User u,string p,List<string> s)
        {
            id = i;
            admin = u;
            people = 1 + s.Count;
            project = p;
            memid = s;
            goals = new List<Tuple<string, DateTime>>();
            goals_achieve = new List<bool>();
        }

        public int GetID() { return id; }
        public User GetAdmin() { return admin; }
        public int GetPeople() { return people; }
        public string GetProject() { return project; }

        public List<string> GetMemid() {  return memid; }

        public List<Tuple<string, DateTime>> GetGoals() {  return goals; }
        public List<bool> GetGoals_Achieve() { return goals_achieve; }
        public void AddGoal(Tuple<string, DateTime> s) { goals.Add(s); }
        public void AddGoal_Achieve(bool s) { goals_achieve.Add(s); }
        public void RemoveGoal(Tuple<string, DateTime> s)
        {
            if (goals.Count == 0)
                return;
            goals.Remove(s);
        }
        public void RemoveGoal(bool s)
        {
            if (goals.Count == 0)
                return;
            goals_achieve.Remove(s);
        }
        public void ChangeAchieve(string s)
        {
            if(goals_achieve.Count == 0) 
                return;
            for(int i = 0; i < goals_achieve.Count; i++)
            {
                if (s == goals[i].Item1)
                {
                    if (goals_achieve[i])
                        goals_achieve[i] = false;
                    else
                        goals_achieve[i] = true;
                }
            }

        }

        public void ChangeAdmin(User u) { admin = u; }
        public void ChangePeople(int i) { people = i; }
        public void AddPeople(int i) { people += i; }
        public void AddMemid(string i) { memid.Add(i); }
        public void RemovePeople(int i) { people -= i; }
    }
}