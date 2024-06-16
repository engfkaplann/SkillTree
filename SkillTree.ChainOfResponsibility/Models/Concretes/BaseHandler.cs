using SkillTree.ChainOfResponsibility.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.ChainOfResponsibility.Models.Concretes
{
    public class BaseHandler : IHandler
    {
        private IHandler _next;

        public void SetNext(IHandler handler)
        {
            _next = handler;
        }

        public virtual void Handle(Person request)
        {
            if(_next != null)
            {
                _next.Handle(request);
            }
            else
            {
                Console.WriteLine($"{request.Name} isn't suitable");
            }
        }
    }
}
