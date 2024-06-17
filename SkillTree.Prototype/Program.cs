using SkillTree.Prototype.Models;
using System;

namespace SkillTree.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 26);

            Person clonePerson = (Person)person.Clone();

            Console.WriteLine($"Name: {clonePerson.Name}");
            Console.WriteLine($"Age: {clonePerson.Age}");

            Console.ReadLine();
        }
    }
}
