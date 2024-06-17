using SkillTree.Composite.Models.Concretes;
using System;

namespace SkillTree.Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizza = new MenuItem("Pizza", 12.99);
            var salate = new MenuItem("Salad", 8.99);
            var burger = new MenuItem("Burger", 10.99);

            var mainMenu = new Menu("Main Menu");
            mainMenu.Add(pizza);
            mainMenu.Add(salate);
            mainMenu.Add(burger);

            var desserMenu = new Menu("Dessert");
            desserMenu.Add(new MenuItem("Ice Cream", 5.99));
            desserMenu.Add(new MenuItem("Pasta", 6.99));


            mainMenu.Add(desserMenu);
            mainMenu.Print();

            Console.ReadLine();
        }
    }
}
