using SkillTree.Composite.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Composite.Models.Concretes
{
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private readonly string _name;

        public Menu(string name)
        {
            _name = name;
        }

        public override void Print()
        {
            Console.WriteLine($"{_name}:");
            foreach (MenuComponent menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }

        public override void Add(MenuComponent component)
        {
            _menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            _menuComponents.Remove(component);
        }
    }
}
