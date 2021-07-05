using System.Collections.Generic;
using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("Transformation")]
    public class Transformation
    {
        [XmlAttribute("RelativeTransfo")]
        public List<double> RelativeTransfo { get; set; }

        public Transformation()
        {
        }

        public Transformation(List<double> relativeTransfo)
        {
            RelativeTransfo.AddRange(relativeTransfo.ToArray());
        }
    }
}
