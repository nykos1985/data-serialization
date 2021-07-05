using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace TestTask
{
    [Serializable]
    [XmlRoot("ModelFile")]
    public class ModelFile
    {
        [XmlElement("ProductOccurence")]
        public List<ProductOccurence> Products { get; set; }

        public ModelFile()
        {
        }

        public ModelFile(List<ProductOccurence> products)
        {
            Products.AddRange(products.ToArray());
        }
    }
}
