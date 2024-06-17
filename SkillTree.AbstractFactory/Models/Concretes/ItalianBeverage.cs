using SkillTree.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Models.Concretes
{
    public class ItalianBeverage : IBeverage
    {
        public void Drink()
        {
            Console.WriteLine("Drinking Italian beverage");
        }
    }
}
