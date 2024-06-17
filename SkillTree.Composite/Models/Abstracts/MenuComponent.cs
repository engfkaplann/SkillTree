using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Composite.Models.Abstracts
{
    public abstract class MenuComponent
    {
        public abstract void Print();
        public virtual void Add(MenuComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
