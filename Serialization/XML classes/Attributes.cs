using System.Collections.Generic;
using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("Attributes")]
    public class Attributes
    {
        [XmlElement("Attr")]
        public List<Attr> Attrs { get; set; }

        public Attributes()
        {
        }

        public Attributes(List<Attr> attrs)
        {
            Attrs.AddRange(attrs.ToArray());
        }
    }
}
