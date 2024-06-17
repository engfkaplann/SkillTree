using SkillTree.Decorator.Models.Abstracts;
using SkillTree.Decorator.Models.Concretes;
using System;

namespace SkillTree.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine($"{espresso.Description}: {espresso.Cost()}$");

            Beverage espressoWithMilk = new Milk(espresso);
            Console.WriteLine($"{espressoWithMilk.Description}: {espressoWithMilk.Cost()}$");

            Console.ReadLine();
        }
    }
}
