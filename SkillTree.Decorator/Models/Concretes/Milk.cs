using SkillTree.Decorator.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Decorator.Models.Concretes
{
    internal class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => _beverage.Description + ", Süt";

        public override double Cost()
        {
            return _beverage.Cost() + 0.50;
        }
    }
}
