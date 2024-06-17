using SkillTree.Singleton.Models.Concretes;
using System;

namespace SkillTree.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonClass singletonObject = SingletonClass.Instance;

            singletonObject.DoSomething();

            Console.ReadLine();
        }
    }
}
