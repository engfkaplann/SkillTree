using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Decorator.Models.Abstracts
{
    public abstract class Beverage
    {
        public abstract string Description { get; }
        public abstract double Cost();
    }
}
