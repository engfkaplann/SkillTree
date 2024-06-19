using Microsoft.Extensions.Caching.Memory;
using SkillTree.MemoryCache.Models.Entities;
using System;

namespace SkillTree.MemoryCache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Extensions.Caching.Memory.MemoryCache cache = new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions());

            Person person = new Person(25, "John", true);

            cache.Set("key", person, TimeSpan.FromSeconds(30));

            if (cache.TryGetValue("key", out Person cachedValue))
            {
                Console.WriteLine($"Cached object name is {cachedValue.Name}");
            }

            cache.Remove("key");

            if (cache.TryGetValue("key", out Person removed))
            {
                
            }
            else
            {
                Console.WriteLine($"Object not found");
            }

            Console.ReadLine();
        }
    }
}
