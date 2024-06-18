using Newtonsoft.Json;
using SkillTree.XMLParsing.Models.Dtos;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SkillTree.XMLParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var response = GetDeserializedXmlContent().Result;

            Console.ReadLine();
        }

        private async static Task<Root> GetDeserializedXmlContent()
        {
            string url = "https://rss.nytimes.com/services/xml/rss/nyt/HomePage.xml";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string xmlString = await response.Content.ReadAsStringAsync();

                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(xmlString);

                        string json = JsonConvert.SerializeXmlNode(doc);

                        return JsonConvert.DeserializeObject<Root>(json);
                    }
                    else
                    {
                        Console.WriteLine($"HTTP request failed: {response.StatusCode}");

                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occured: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
