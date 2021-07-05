using System.Collections.Generic;
using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("ProductOccurence")]
    public class ProductOccurence
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Behaviour")]
        public int Behaviour { get; set; }

        [XmlAttribute("Children")]
        public int Children { get; set; }

        [XmlAttribute("Unit")]
        public double Unit { get; set; }

        [XmlAttribute("IsPart")]
        public bool IsPart { get; set; }

        [XmlAttribute("FilePath")]
        public string FilePath { get; set; }

        [XmlAttribute("Style")]
        public int Style { get; set; }

        [XmlAttribute("InstanceRef")]
        public int InstanceRef { get; set; }

        [XmlElement("Attributes")]
        public List<Attributes> Attributes { get; set; }

        [XmlElement("BodyInstance")]
        public List<BodyInstance> BodyInstance { get; set; }

        [XmlElement("Transformation")]
        public List<Transformation> Transformation { get; set; }

        [XmlElement("PartDefinition")]
        public List<PartDefinition> PartDefinition { get; set; }

        public ProductOccurence()
        {
        }

        public ProductOccurence(int id, string name, int style, int behaviour, int children, bool isPart)
        {
            Id = id;
            Name = name;
            Behaviour = behaviour;
            Children = children;
            Style = style;
            IsPart = isPart;
        }

        public ProductOccurence(int id, string name, int behaviour, double unit, bool isPart)
        {
            Id = id;
            Name = name;
            Behaviour = behaviour;
            Unit = unit;
            IsPart = isPart;
        }
        public ProductOccurence(int id, string name, int style, int behaviour, string filePath, int children, bool isPart, List<Attributes> attributes)
        {
            Id = id;
            Name = name;
            Behaviour = behaviour;
            Children = children;
            Style = style;
            FilePath = filePath;
            IsPart = isPart;
            Attributes.AddRange(attributes.ToArray());
        }

        public ProductOccurence(int id, string name, int behaviour, int children, double unit, bool isPart, List<Attributes> attributes)
        {
            Id = id;
            Name = name;
            Behaviour = behaviour;
            Children = children;
            Unit = unit;
            IsPart = isPart;
            Attributes.AddRange(attributes.ToArray());
        }

        public ProductOccurence(int id, string name, int style, int behaviour, int children, bool isPart, List<Attributes> attributes)
        {
            Id = id;
            Name = name;
            Style = style;
            Behaviour = behaviour;
            Children = children;
            IsPart = isPart;
            Attributes.AddRange(attributes.ToArray());
        }

        

        public ProductOccurence(int id, string name, int style, int behaviour, int instanceRef, bool isPart,
            List<Transformation> transformation, List<Attributes> attributes, List<BodyInstance> bodyInstance)
        {
            Id = id;
            Name = name;
            Style = style;
            Behaviour = behaviour;
            InstanceRef = instanceRef;
            IsPart = isPart;
            Transformation.AddRange(transformation.ToArray());
            Attributes.AddRange(attributes.ToArray());
            BodyInstance.AddRange(bodyInstance.ToArray());
        }
    }
}
