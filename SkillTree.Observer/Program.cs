using SkillTree.Observer.Models.Concretes;
using System;

namespace SkillTree.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Observable observable = new();

            Models.Concretes.Observer observer1 = new("Observer1");
            Models.Concretes.Observer observer2 = new("Observer2");
            Models.Concretes.Observer observer3 = new("Observer3");

            observable.Register(observer1);
            observable.Register(observer2);
            observable.Register(observer3);

            observable.SendMessage("Hello world!");

            Console.ReadLine();
        }
    }
}
