using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Memento.Models.Concretes
{
    public class Originator
    {
        private string _state = "";

        public void Restore(Memento memento)
        {
            _state = memento.GetText();
            Console.WriteLine("Restored State : " + _state);
        }

        public Memento Save()
        {
            return new Memento(_state);
        }

        public void ChangeState(string state)
        {
            _state = state;
            Console.WriteLine("Current State : " + _state);
        }
    }
}
