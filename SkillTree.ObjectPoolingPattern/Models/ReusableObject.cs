using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.ObjectPoolingPattern.Models
{
    public class ReusableObject
    {
        private static int _idCounter = 1;

        private int _id;

        public ReusableObject()
        {
            _id = _idCounter;
            
            Console.WriteLine($"{nameof(ReusableObject)}object created. Id : {_id}");

            _idCounter++;
        }

        public void Write() => Console.WriteLine($"Id : {_id}");
        
    }
}
