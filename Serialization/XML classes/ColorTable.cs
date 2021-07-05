using System.Collections.Generic;
using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("ColorTable")]
    public class ColorTable
    {
        [XmlAttribute("size")]
        public int Size { get; set; }

        [XmlAttribute("data")]
        public List<double> Data { get; set; }

        public ColorTable()
        {
        }

        public ColorTable(int size, List<double> data)
        {
            Size = size;
            Data.AddRange(data.ToArray());
        }
    }
}
