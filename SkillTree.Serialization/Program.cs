using SkillTree.Serialization.Models.Entities;
using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace SkillTree.Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(21, "John", true);

            string xml = SerializeToXml(person);
            string json = SerializeToJson(person);

            Console.ReadLine();
        }

        private static string SerializeToXml(Person person)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, person);
                return writer.ToString();
            }
        }

        private static string SerializeToJson(Person person)
        {
            return JsonSerializer.Serialize(person);
        }
    }
}
