using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Reflection.Models.Entities
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public bool Graduated { get; set; }

        public Person()
        {

        }

        public Person(int age, string name, bool graduated)
        {
            Age = age;
            Name = name;
            Graduated = graduated;
        }

        public void SayMyName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
