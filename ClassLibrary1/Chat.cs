using Myclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable]
    public class Chat : Packet
    {
        private User sender;
        private string whispher_id;
        private string message;
        public Chat(User u, string w_id,string message)
        {
            this.sender = u;
            whispher_id = w_id; 
            this.message = message;
        }
        public User GetUser() { return sender; }
        public string GetWhispher_id() { return whispher_id; }
        public string GetMessage() { return message; }
    }
}
