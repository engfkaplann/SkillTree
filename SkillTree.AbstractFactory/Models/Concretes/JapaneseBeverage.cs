using SkillTree.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Models.Concretes
{
    public class JapaneseBeverage : IBeverage
    {
        public void Drink()
        {
            Console.WriteLine("Drinking Japanese beverage");
        }
    }
}
