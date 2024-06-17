using SkillTree.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Models.Concretes
{
    public class JapaneseMenuFactory : IMenuFactory
    {
        public IBeverage CreateBeverage()
        {
            return new JapaneseBeverage();
        }

        public IMainCourse CreateMainCourse()
        {
            return new JapaneseMainCourse();
        }
    }
}
