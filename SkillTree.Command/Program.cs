using SkillTree.Command.Models.Abstracts;
using SkillTree.Command.Models.Concretes;
using System;


namespace SkillTree.Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new();

            ICommand openCommand = new OpenCommand();
            invoker.SetCommand(openCommand);

            ICommand printCommand = new PrintCommand();
            invoker.SetCommand(printCommand);

            ICommand saveCommand = new SaveCommand();
            invoker.SetCommand(saveCommand);

            invoker.ExecuteCommands();

            Console.ReadLine();
        }
    }
}
