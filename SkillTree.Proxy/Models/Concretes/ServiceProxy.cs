using SkillTree.Proxy.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Proxy.Models.Concretes
{
    public class ServiceProxy : IService
    {
        private IService _service;

        public void OperationA()
        {
            if(_service == null)
            {
                _service = new Service();
            }

            _service.OperationA();
        }
    }
}
