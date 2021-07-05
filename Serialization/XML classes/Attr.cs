using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("Attr")]
    public class Attr
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string Value { get; set; }

        public Attr()
        {
        }

        public Attr(string name, string type, string value)
        {
            Name = name;
            Type = type;
            Value = value;
        }
    }
}
