using SkillTree.ChainOfResponsibility.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.ChainOfResponsibility.Models.Abstracts
{
    public interface IHandler
    {
        public void SetNext(IHandler handler);
        public void Handle(Person request);
    }
}
