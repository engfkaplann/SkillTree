using SkillTree.PipelineDesignPatter.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.PipelineDesignPatter.Models.Concretes
{
    public class Pipeline<T>
    {
        private readonly List<IOperation<T>> operations = new List<IOperation<T>>();

        public void Register(IOperation<T> operation)
        {
            operations.Add(operation);
        }

        public void Invoke(T data)
        {
            foreach (var operation in operations) operation.Invoke(data);
        }
    }
}
