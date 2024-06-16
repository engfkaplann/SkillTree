using SkillTree.Command.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Command.Models.Concretes
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Save command executed");
        }
    }
}
