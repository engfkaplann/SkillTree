using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.PipelineDesignPatter.Models.Abstracts
{
    public interface IOperation<T>
    {
        void Invoke(T data);
    }
}
