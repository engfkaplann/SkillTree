using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SkillTree.XMLParsing.Models.Dtos
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AtomLink
    {
        [JsonProperty("@href")]
        public string href { get; set; }

        [JsonProperty("@rel")]
        public string rel { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
    }

    public class Channel
    {
        public string title { get; set; }
        public string link { get; set; }

        [JsonProperty("atom:link")]
        public AtomLink atomlink { get; set; }
        public string description { get; set; }
        public string language { get; set; }
        public string copyright { get; set; }
        public string lastBuildDate { get; set; }
        public string pubDate { get; set; }
        public Image image { get; set; }
        public List<Item> item { get; set; }
    }

    public class Guid
    {
        [JsonProperty("@isPermaLink")]
        public string isPermaLink { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class Image
    {
        public string title { get; set; }
        public string url { get; set; }
        public string link { get; set; }
    }

    public class Item
    {
        public string title { get; set; }
        public string link { get; set; }
        public Guid guid { get; set; }

        [JsonProperty("atom:link")]
        public AtomLink atomlink { get; set; }
        public string description { get; set; }

        [JsonProperty("dc:creator")]
        public string dccreator { get; set; }
        public string pubDate { get; set; }
        public object category { get; set; }

        [JsonProperty("media:content")]
        public MediaContent mediacontent { get; set; }

        [JsonProperty("media:credit")]
        public string mediacredit { get; set; }

        [JsonProperty("media:description")]
        public string mediadescription { get; set; }
    }

    public class MediaContent
    {
        [JsonProperty("@height")]
        public string height { get; set; }

        [JsonProperty("@medium")]
        public string medium { get; set; }

        [JsonProperty("@url")]
        public string url { get; set; }

        [JsonProperty("@width")]
        public string width { get; set; }
    }

    public class Root
    {
        [JsonProperty("?xml")]
        public Xml xml { get; set; }
        public Rss rss { get; set; }
    }

    public class Rss
    {
        [JsonProperty("@xmlns:dc")]
        public string xmlnsdc { get; set; }

        [JsonProperty("@xmlns:media")]
        public string xmlnsmedia { get; set; }

        [JsonProperty("@xmlns:atom")]
        public string xmlnsatom { get; set; }

        [JsonProperty("@xmlns:nyt")]
        public string xmlnsnyt { get; set; }

        [JsonProperty("@version")]
        public string version { get; set; }
        public Channel channel { get; set; }
    }

    public class Xml
    {
        [JsonProperty("@version")]
        public string version { get; set; }

        [JsonProperty("@encoding")]
        public string encoding { get; set; }
    }






}
