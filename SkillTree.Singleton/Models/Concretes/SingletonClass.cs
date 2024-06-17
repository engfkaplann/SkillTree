using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Singleton.Models.Concretes
{
    public class SingletonClass
    {
        private static SingletonClass _instance;
        private static readonly object _lock = new object();

        public static SingletonClass Instance
        {
            get 
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance = new SingletonClass();
                    }

                }

                return _instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something");
        }
    }
}
