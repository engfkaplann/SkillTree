using SkillTree.Observer.Models.Abstracts;
using System;

namespace SkillTree.Observer.Models.Concretes
{
    public class Observer : IObserver
    {
        private string _name;

        public Observer(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received message: {message}");
        }
    }
}