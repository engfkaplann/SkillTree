﻿using SkillTree.Decorator.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Decorator.Models.Concretes
{
    public class Espresso : Beverage
    {
        public override string Description => "Espresso";

        public override double Cost()
        {
            return 15.50;
        }
    }
}
