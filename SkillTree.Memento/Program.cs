using SkillTree.Memento.Models.Concretes;
using System;

namespace SkillTree.Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();

            caretaker.WriteText("Text1");
            caretaker.WriteText("Text2");
            caretaker.WriteText("Text3");
            caretaker.Undo();
            caretaker.WriteText("Text4");
            caretaker.Undo();


            Console.ReadLine();
        }
    }
}
