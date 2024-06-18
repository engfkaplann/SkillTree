using SkillTree.PipelineDesignPatter.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.PipelineDesignPatter.Models.Concretes
{
    public class Operation<T> : IOperation<T>
    {
        private readonly Action<T> action;

        public Operation(Action<T> action)
        {
            this.action = action;
        }

        public void Invoke(T data) => action(data);
    }
}
