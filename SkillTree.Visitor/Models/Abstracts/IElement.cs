using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Visitor.Models.Abstracts
{
    public interface IElement
    {
        public void Accept(IVisitor visitor);
    }
}
