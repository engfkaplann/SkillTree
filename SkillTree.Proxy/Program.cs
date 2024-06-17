using SkillTree.Proxy.Models.Abstracts;
using SkillTree.Proxy.Models.Concretes;
using System;

namespace SkillTree.Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IService proxyService = new ServiceProxy();
            proxyService.OperationA();

            Console.ReadLine();
        }
    }
}
