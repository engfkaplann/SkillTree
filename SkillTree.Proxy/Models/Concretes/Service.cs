using SkillTree.Proxy.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Proxy.Models.Concretes
{
    public class Service : IService
    {
        public void OperationA()
        {
            Console.WriteLine("OperationA executed");
        }
    }
}
