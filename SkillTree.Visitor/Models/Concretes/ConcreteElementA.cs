using SkillTree.Visitor.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Visitor.Models.Concretes
{
    public class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string OperationA()
        {
            return "ConcreteElementA operation";
        }
    }
}
