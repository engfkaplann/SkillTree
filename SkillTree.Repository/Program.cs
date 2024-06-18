using SkillTree.Repository.Models.Abstracts;
using SkillTree.Repository.Models.Concretes;
using SkillTree.Repository.Models.Entities;
using System;

namespace SkillTree.Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                IRepository<Product> productRepository = new RepositoryBase<Product>(context);

                //Create
                Product newProduct = new Product { Name = "New Product", Price = 100 };
                productRepository.Add(newProduct);
                
                //Get
                Product updateProduct = productRepository.GetById(1);
                if (updateProduct != null)
                {
                    //Update
                    updateProduct.Name = "Updated Product";
                    updateProduct.Price = 150;
                    productRepository.Update(updateProduct);
                }

                //Delete
                productRepository.Remove(2);

                //Read
                var products = productRepository.GetAll();
                foreach (var product in products)
                {
                    Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                }
            }
        }
    }
}
