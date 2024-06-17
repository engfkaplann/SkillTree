using SkillTree.Interpreter.Models.Abstracts;
using SkillTree.Interpreter.Models.Concretes;
using System;
using System.Collections.Generic;

namespace SkillTree.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MMMMDCCCLXXII";//4872
            Context context = new(roman);
            List<RomanNumeralExpression> tree = new()
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");

            Console.ReadLine();
        }
    }
}
