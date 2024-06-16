using SkillTree.Strategy.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Strategy.Models.Concretes
{
    public class StrategyB : IStrategy
    {
        public void Execute(CustomData data)
        {
            Console.WriteLine($"text character count: {data.Text.Length}");
        }
    }
}
