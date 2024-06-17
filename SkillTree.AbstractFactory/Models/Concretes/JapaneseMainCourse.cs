using SkillTree.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Models.Concretes
{
    public class JapaneseMainCourse : IMainCourse
    {
        public void Eat()
        {
            Console.WriteLine("Eating Japanese main course");
        }
    }
}
