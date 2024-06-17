using SkillTree.FactoryMethod.Models.Abstracts;
using SkillTree.FactoryMethod.Models.Concretes;
using System;

namespace SkillTree.FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory factoryECommerce = new WebSiteFactoryECommerce();
            WebSite eCommerceWebSite = factoryECommerce.CreateWebSite();
            eCommerceWebSite.CreatePages();

            WebSiteFactory factoryBlog = new WebSiteFactoryBlog();
            WebSite blogWebSite = factoryBlog.CreateWebSite();
            blogWebSite.CreatePages();

            Console.ReadLine();
        }
    }
}
