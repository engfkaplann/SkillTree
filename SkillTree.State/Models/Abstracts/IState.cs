using SkillTree.State.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.State.Models.Abstracts
{
    public interface IState
    {
        public void DoThat();
        public void SetContext(StateContext context);
    }
}
