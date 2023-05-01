using HW12.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var EarPods = new WiredHeadphones("Apple", "EarPods", "Earbud", "Wire", "White", 1.0);

            XmlSerializer serializer = new XmlSerializer(typeof(WiredHeadphones));
            StringBuilder sb = new StringBuilder();
            using (StringWriter writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, EarPods);
            }
            string xmlString = sb.ToString();

            Console.WriteLine(xmlString);

            var reader = new StringReader(xmlString);
            var deserializedEarPods = (WiredHeadphones)serializer.Deserialize(reader);
            Console.WriteLine(deserializedEarPods.ToString());



            var AirPods = new WirelessHeadphones("Apple", "AirPods", "Vacuum", "Wireless", "White", 100);
            

            string json = JsonConvert.SerializeObject(AirPods);

            Console.WriteLine(json);

            var AirPodsDeserialized = JsonConvert.DeserializeObject<WirelessHeadphones>(json);

            Console.WriteLine(AirPodsDeserialized.ToString());

            Console.ReadKey();

        }
    }
}
