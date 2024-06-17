using SkillTree.Visitor.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillTree.Visitor.Models.Concretes
{
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ConcreteElementA elementA)
        {
            Console.WriteLine($"ConcreteVisitor processing {elementA.OperationA()}");
        }

        public void Visit(ConcreteElementB elementB)
        {
            Console.WriteLine($"ConcreteVisitor processing {elementB.OperationB()}");
        }
    }
}
