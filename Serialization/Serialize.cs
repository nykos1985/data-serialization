using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;


namespace TestTask
{
    class Serialize
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "test.xml");
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Root";
            xRoot.IsNullable = true;
            Root result = new Root();

            XmlSerializer formatter = new XmlSerializer(typeof(Root), xRoot);

            using (FileStream fs =new FileStream(path, FileMode.Open))
            {
                result = (Root)formatter.Deserialize(fs);
            }

            var json = new DataContractJsonSerializer(typeof(Root));

            using (FileStream fs = new FileStream("result.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(fs, result);
            }
        }
    }
}
