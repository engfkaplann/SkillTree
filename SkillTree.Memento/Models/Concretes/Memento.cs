using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Memento.Models.Concretes
{
    public class Memento
    {
        private readonly string _text;

        public Memento(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
