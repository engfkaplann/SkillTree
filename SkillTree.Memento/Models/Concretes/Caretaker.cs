using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Memento.Models.Concretes
{
    public class Caretaker
    {
        private Originator _originator = new Originator();
        private Stack<Memento> _history = new Stack<Memento>();

        public void WriteText(string text)
        {
            _history.Push(_originator.Save());

            _originator.ChangeState(text);
        }

        public void Undo()
        {
            if(_history.Count == 0)
            {
                return;
            }

            Memento memento = _history.Pop();

            _originator.Restore(memento);
        }
    }
}
