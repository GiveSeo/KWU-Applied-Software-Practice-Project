﻿using System;
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
        public Team(int i, User u, string p)
        {
            id = i;
            admin = u;
            people = 1;
            project = p;
            memid= new List<string>();
            goals = new List<Tuple<string, DateTime>>();
        }

        public Team(int i,User u,string p,List<string> s)
        {
            id = i;
            admin = u;
            people = 1 + s.Count;
            project = p;
            memid = s;
            goals = new List<Tuple<string, DateTime>>();
        }

        public int GetID() { return id; }
        public User GetAdmin() { return admin; }
        public int GetPeople() { return people; }
        public string GetProject() { return project; }

        public List<string> GetMemid() {  return memid; }

        public List<Tuple<string, DateTime>> GetGoals() {  return goals; }
        public void AddGoal(Tuple<string, DateTime> s) { goals.Add(s); }
        public void RemoveGoal(Tuple<string, DateTime> s)
        {
            if (goals.Count == 0)
                return;
            goals.Remove(s);
        }

        public void ChangeAdmin(User u) { admin = u; }
        public void ChangePeople(int i) { people = i; }
        public void AddPeople(int i) { people += i; }
        public void AddMemid(string i) { memid.Add(i); }
        public void RemovePeople(int i) { people -= i; }
    }
}