using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Models.Abstracts
{
    public interface IMenuFactory
    {
        public IBeverage CreateBeverage();
        public IMainCourse CreateMainCourse();
    }
}
