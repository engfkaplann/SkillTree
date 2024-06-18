using SkillTree.PipelineDesignPatter.Models.Concretes;
using System;

namespace SkillTree.PipelineDesignPatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pipeline = new Pipeline<string>();

            // lambda
            pipeline.Register(new Operation<string>(str =>
            {
                Console.WriteLine($"The string {str} contains {str.Length} characters.");
            }));

            // class
            pipeline.Register(new ReverseOperation());
            pipeline.Register(new LengthOperation());

            // execute
            pipeline.Invoke("Hello world!");

            Console.ReadLine();
        }
    }
}
