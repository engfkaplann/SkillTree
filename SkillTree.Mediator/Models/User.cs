using SkillTree.Mediator.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Mediator.Models
{
    public abstract class User
    {
        public string Name { get; set; }
        public IChatRoomMediator ChatRoom { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Send(string to, string message)
        {
            ChatRoom.Send(Name, to, message);
        }

        public abstract void Receive(string from, string message);
    }
}
