using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.ObjectPoolingPattern.Models.Concretes
{
    public class ObjectPool<T>
    {
        private readonly ConcurrentBag<T> _objects;
        private readonly Func<T> _objectGenerator;
        public ObjectPool(Func<T> objectGenerator)
        {
            _objectGenerator = objectGenerator ?? throw new ArgumentException(nameof(objectGenerator));
            _objects = new ConcurrentBag<T>();
        }

        public T Get() 
        {
            return _objects.TryTake(out T item) ? item : _objectGenerator();
        } 
        public void Return(T item)
        {
            _objects.Add(item);
        }
        
    }
}
