using System.Collections.Generic;
using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("BodyInstance")]
    public class BodyInstance
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Behaviour")]
        public int Behaviour { get; set; }

        [XmlAttribute("BodyRef")]
        public int BodyRef { get; set; }

        [XmlElement("Transformation")]
        public List<Transformation> Transformation { get; set; }

        public BodyInstance()
        {
        }

        public BodyInstance(int id, string name, int behaviour, int bodyRef)
        {
            Id = id;
            Name = name;
            Behaviour = behaviour;
            BodyRef = bodyRef;
        }

        public BodyInstance(int id, string name, int behaviour, int bodyRef, List<Transformation> transformation)
        {
            Id = id;
            Name = name;
            Behaviour = behaviour;
            BodyRef = bodyRef;
            Transformation.AddRange(transformation.ToArray());
        }
    }
}
