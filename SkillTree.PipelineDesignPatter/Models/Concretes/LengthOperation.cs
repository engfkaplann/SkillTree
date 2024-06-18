using SkillTree.PipelineDesignPatter.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.PipelineDesignPatter.Models.Concretes
{
    internal class LengthOperation : IOperation<string>
    {
        public void Invoke(string data)
        {
            Console.WriteLine($"String length : {data.Length}");
        }
    }
}
