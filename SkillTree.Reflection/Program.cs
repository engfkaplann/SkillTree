using SkillTree.Reflection.Models.Entities;
using System;
using System.Reflection;

namespace SkillTree.Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(22, "John", true);

            TypeNameWriter(person);
            CallMethod(person, "SayMyName");
            PropertyWriter(person, "Age");

            Console.ReadLine();
        }

        private static void TypeNameWriter(object obj)
        {
            var className = obj.GetType().Name;
            Console.WriteLine($"Type Name: {className}");
        }

        private static void CallMethod(object obj, string methodName)
        {
            try
            {
                Type type = obj.GetType();
                MethodInfo method = type.GetMethod(methodName);
                method.Invoke(obj, null);
            }
            catch
            {
                Console.WriteLine($"Method {methodName} not found");
            }
        }

        private static void PropertyWriter(object obj, string propertyName)
        {
            try
            {
                Type type = obj.GetType();
                PropertyInfo propertyInfo = type.GetProperty(propertyName);

                object propertyValue = propertyInfo.GetValue(obj);

                if (propertyValue != null)
                {
                    Console.WriteLine($"Property {propertyName} Value: {propertyValue}");
                }
            }
            catch
            {
                Console.WriteLine($"Propert {propertyName} not found");
            }
            
        }
    }
}
