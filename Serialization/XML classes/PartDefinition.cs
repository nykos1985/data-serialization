using System.Collections.Generic;
using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("PartDefinition")]
    public class PartDefinition
    {
        [XmlElement("Body")]
        public List<Body> Body { get; set; }

        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Behaviour")]
        public int Behaviour { get; set; }

        public PartDefinition()
        {
        }

        public PartDefinition(int id, string name, int behaviour, List<Body> body)
        {
            Id = id;
            Name = name;
            Behaviour = behaviour;
            Body.AddRange(body.ToArray());
        }
    }
}
