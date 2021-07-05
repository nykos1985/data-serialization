using System.Xml.Serialization;


namespace TestTask
{
    [XmlRoot("Style")]
    public class Style
    {
        [XmlAttribute("ColorIndex")]
        public int ColorIndex { get; set; }

        [XmlAttribute("Width")]
        public double Width { get; set; }

        [XmlAttribute("Transparency")]
        public int Transparency { get; set; }

        public Style()
        {
        }

        public Style(int cIndex, double width)
        {
            Width = width;
            ColorIndex = cIndex;
        }

        public Style(int cIndex, int transparency, double width)
        {
            ColorIndex = cIndex;
            Transparency = transparency;
            Width = width;
        }

    }
}
