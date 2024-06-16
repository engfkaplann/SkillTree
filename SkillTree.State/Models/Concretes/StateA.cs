using SkillTree.State.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.State.Models.Concretes
{
    public class StateA : StateBase
    {
        public override void DoThat()
        {
            var stateName = this.GetType().Name;

            Console.WriteLine($"{stateName} DoThat");

            IState newState = new StateB();
            _context.ChangeState(newState);
        }
    }
}
