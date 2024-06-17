using SkillTree.Visitor.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Visitor.Models.Abstracts
{
    public interface IVisitor
    {
        public void Visit(ConcreteElementA elementA);
        public void Visit(ConcreteElementB elementB);
    }
}
