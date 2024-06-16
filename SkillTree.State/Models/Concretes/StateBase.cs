using SkillTree.State.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.State.Models.Concretes
{
    public abstract class StateBase : IState
    {
        protected StateContext _context;

        public void SetContext(StateContext context)
        {
            _context = context;
        }

        public abstract void DoThat();

    }
}
