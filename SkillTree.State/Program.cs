using SkillTree.State.Models.Abstracts;
using SkillTree.State.Models.Concretes;
using System;

namespace SkillTree.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IState initialState = new StateA();

            StateContext context = new StateContext(initialState);

            context.DoThat();//StateA
            context.DoThat();//StateB

            Console.ReadLine();
        }
    }
}
