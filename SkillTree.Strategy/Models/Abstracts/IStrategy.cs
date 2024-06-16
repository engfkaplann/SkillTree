using SkillTree.Strategy.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Strategy.Models.Abstracts
{
    public interface IStrategy
    {
        public void Execute(CustomData data);
    }
}
