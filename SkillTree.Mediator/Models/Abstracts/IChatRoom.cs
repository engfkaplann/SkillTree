using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Mediator.Models.Abstracts
{
    public interface IChatRoomMediator
    {
        public void Register(User user);

        public void Send(string from, string to, string message);
    }
}
