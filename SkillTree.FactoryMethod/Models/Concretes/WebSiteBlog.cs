using SkillTree.FactoryMethod.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.FactoryMethod.Models.Concretes
{
    public class WebSiteBlog : WebSite
    {
        public override void CreatePages()
        {
            Console.WriteLine("Creating blog web site's pages");
        }
    }
}
