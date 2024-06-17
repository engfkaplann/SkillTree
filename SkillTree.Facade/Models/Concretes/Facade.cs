using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Facade.Models.Concretes
{
    public class Facade
    {
        protected SubSystem1 _subSystem1;
        protected SubSystem2 _subSystem2;
        public Facade(SubSystem1 altSistem1, SubSystem2 altSistem2)
        {
            _subSystem1 = altSistem1;
            _subSystem2 = altSistem2;
        }

        public string OperationA()
        {
            return "Facade: OperationA\n" + _subSystem1.Operation1() + _subSystem2.Operation1();
        }

        public string OperationB()
        {
            return "Facade: OperationB\n" + _subSystem1.Operation2() + _subSystem2.Operation2();
        }
    }
}
