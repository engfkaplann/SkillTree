using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Decorator.Models.Abstracts
{
    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;

        public BeverageDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}
