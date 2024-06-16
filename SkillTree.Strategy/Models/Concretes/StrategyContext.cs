using SkillTree.Strategy.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Strategy.Models.Concretes
{
    public class StrategyContext
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ProcessData(CustomData data)
        {
            _strategy.Execute(data);
        }
    }
}
