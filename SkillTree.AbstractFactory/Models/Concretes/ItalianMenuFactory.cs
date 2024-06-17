using SkillTree.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Models.Concretes
{
    public class ItalianMenuFactory : IMenuFactory
    {
        public IBeverage CreateBeverage()
        {
            return new ItalianBeverage();            
        }

        public IMainCourse CreateMainCourse()
        {
            return new ItalianMainCourse();
        }
    }
}
