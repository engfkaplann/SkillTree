using SkillTree.Interpreter.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Interpreter.Models.Abstracts
{
    public abstract class RomanNumeralExpression
    {
        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();

        public void Interpret(Context context)
        {
            if (context.Input.Length == 0) return;

            if (context.Input.StartsWith(Nine())) //IX
            {
                context.Output += (9 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Output += (4 * Multiplier()); //IV
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += (5 * Multiplier()); //V
                context.Input = context.Input.Substring(1);
            }


            while (context.Input.StartsWith(One())) //I
            {
                context.Output += (1 * Multiplier());
                context.Input = context.Input.Substring(1);
            }
        }
    }
}
