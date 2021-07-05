using System.Collections.Generic;
using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("GlobalData")]
    public class GlobalData
    {
        [XmlElement("ColorTable")]
        public List<ColorTable> CTable { get; set; }

        [XmlElement("Style")]
        public List<Style> Style { get; set; }

        public GlobalData()
        {
        }

        public GlobalData(List<ColorTable> cTable, List<Style> style)
        {
            CTable.AddRange(cTable.ToArray());
            Style.AddRange(style.ToArray());
        }
    }
}
