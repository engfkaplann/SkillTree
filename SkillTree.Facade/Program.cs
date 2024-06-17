using SkillTree.Facade.Models.Concretes;
using System;

namespace SkillTree.Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubSystem1 subSystem1 = new();
            SubSystem2 subSystem2 = new();

            Models.Concretes.Facade facade = new Models.Concretes.Facade(subSystem1, subSystem2);


            Console.WriteLine("Operation A");
            Console.WriteLine(facade.OperationA());

            Console.WriteLine("Operation B");
            Console.WriteLine(facade.OperationB());

            Console.ReadLine();
        }
    }
}
