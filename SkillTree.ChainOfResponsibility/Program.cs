using SkillTree.ChainOfResponsibility.Models.Concretes;
using System;

namespace SkillTree.ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ageHandler = new ConcreteHandlerAge();
            var graduatedHandler = new ConcreteHandlerGraduated();

            ageHandler.SetNext(graduatedHandler);

            Person person1 = new Person
            {
                Name = "Chris",
                Age = 20,
                Graduated = true
            };

            Person person2 = new Person
            {
                Name = "Rebecca",
                Age = 26,
                Graduated = true
            };

            Person person3 = new Person
            {
                Name = "John",
                Age = 20,
                Graduated = false
            };

            ageHandler.Handle(person1);
            ageHandler.Handle(person2);
            ageHandler.Handle(person3);

            Console.ReadLine();
        }
    }
}
