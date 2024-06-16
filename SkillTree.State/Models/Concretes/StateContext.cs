using SkillTree.State.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.State.Models.Concretes
{
    public class StateContext
    {
        private IState _state;

        public StateContext(IState state)
        {
            _state = state;
            _state.SetContext(this);
        }

        public void ChangeState(IState state)
        {
            _state = state;
            _state.SetContext(this);
        }

        public void DoThat()
        {
            _state.DoThat();
        }
    }
}
