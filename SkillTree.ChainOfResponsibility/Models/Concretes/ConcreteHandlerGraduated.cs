using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.ChainOfResponsibility.Models.Concretes
{
    public class ConcreteHandlerGraduated : BaseHandler
    {
        public override void Handle(Person request)
        {
            if (request.Graduated)//If can handle
            { 
                RequestHandler(request);
            }
            else//If can't handle
            {
                base.Handle(request);
            }
        }

        private void RequestHandler(Person request)
        {
            Console.WriteLine($"{request.Name}'s graduation status is appropriate");
        }
    }
}
