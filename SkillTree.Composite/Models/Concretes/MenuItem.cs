using SkillTree.Composite.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Composite.Models.Concretes
{
    public class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly double _price;

        public MenuItem(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public override void Print()
        {
            Console.WriteLine($"- {_name}: ${_price}");
        }
    }
}
