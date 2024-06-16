using SkillTree.Command.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Command.Models.Concretes
{
    public class Invoker
    {
        private Queue<ICommand> _commands = new Queue<ICommand>();

        public void SetCommand(ICommand command)
        {
            _commands.Enqueue(command);
        }

        public void ExecuteCommands()
        {
            while (_commands.Count > 0)
            {
                ICommand command = _commands.Dequeue();
                command.Execute();
            }
        }
    }
}
