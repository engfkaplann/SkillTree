using SkillTree.Mediator.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Mediator.Models.Concretes
{
    public class ChatRoomMediator : IChatRoomMediator
    {
        private Dictionary<string, User> _users = new();

        public void Register(User user)
        {
            if(_users.ContainsKey(user.Name))
            {
                return;
            }

            user.ChatRoom = this;
            _users[user.Name] = user;
        }

        public void Send(string from, string to, string message)
        {
            if(!_users.ContainsKey(from) || !_users.ContainsKey(to))
            {
                Console.WriteLine($"User not found");
                return;
            }

            _users[to].Receive(from, message);
        }
    }
}
