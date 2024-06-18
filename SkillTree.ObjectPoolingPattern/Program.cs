using SkillTree.ObjectPoolingPattern.Models;
using SkillTree.ObjectPoolingPattern.Models.Concretes;
using System;

namespace SkillTree.ObjectPoolingPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<ReusableObject> objectPool = new ObjectPool<ReusableObject>(() => new ReusableObject());

            ReusableObject object1 = objectPool.Get();
            object1.Write();
            objectPool.Return(object1);

            ReusableObject object2 = objectPool.Get();
            object2.Write();

            ReusableObject object3 = objectPool.Get();
            object3.Write();

            objectPool.Return(object2);

            Console.ReadLine();
        }
    }
}
