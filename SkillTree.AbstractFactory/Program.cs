using SkillTree.Models.Abstracts;
using SkillTree.Models.Concretes;
using System;

namespace SkillTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenuFactory italianMenuFactory = new ItalianMenuFactory();
            IMenuFactory japaneseMenuFactory = new JapaneseMenuFactory();

            IBeverage italianBeverage = italianMenuFactory.CreateBeverage();
            IMainCourse italianMainCourse = italianMenuFactory.CreateMainCourse();

            IBeverage japaneseBeverage = japaneseMenuFactory.CreateBeverage();
            IMainCourse japaneseMainCourse = japaneseMenuFactory.CreateMainCourse();

            italianBeverage.Drink();
            italianMainCourse.Eat();

            japaneseBeverage.Drink();
            japaneseMainCourse.Eat();

            Console.ReadLine();
        }
    }
}
