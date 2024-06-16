using SkillTree.Strategy.Models.Concretes;
using System;

namespace SkillTree.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext();

            CustomData data = new CustomData
            {
                Text = "Weather is cold"
            };

            StrategyA strategyA = new StrategyA();
            context.SetStrategy(strategyA);
            context.ProcessData(data);

            StrategyB strategyB = new StrategyB();
            context.SetStrategy(strategyB);
            context.ProcessData(data);

            Console.ReadLine();
        }
    }
}
