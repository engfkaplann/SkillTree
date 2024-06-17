using SkillTree.Visitor.Models.Abstracts;
using SkillTree.Visitor.Models.Concretes;
using System;

namespace SkillTree.Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elements = new IElement[] { new ConcreteElementA(), new ConcreteElementB() };
            var visitor = new ConcreteVisitor();

            foreach (var element in elements)
            {
                element.Accept(visitor);
            }

            Console.ReadLine();
        }
    }
}
