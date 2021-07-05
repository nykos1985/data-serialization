using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("Body")]
    public class Body
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Style")]
        public int Style { get; set; }

        [XmlAttribute("Behaviour")]
        public int Behaviour { get; set; }

        public Body()
        {
        }

        public Body(int id, string name, int style, int behaviour)
        {
            Id = id;
            Name = name;
            Style = style;
            Behaviour = behaviour;
        }
    }
}
