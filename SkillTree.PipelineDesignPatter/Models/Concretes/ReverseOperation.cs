using SkillTree.PipelineDesignPatter.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.PipelineDesignPatter.Models.Concretes
{
    public class ReverseOperation : IOperation<string>
    {
        public void Invoke(string data)
        {
            Console.WriteLine($"The string is reversed : {new string(data.Reverse().ToArray()) }");
        }
    }
}
