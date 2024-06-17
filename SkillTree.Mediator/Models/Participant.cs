using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Mediator.Models
{
    public class Participant : User
    {
        public Participant(string name): base(name)
        {

        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"Message received from {from} : {message}");
        }
    }
}
