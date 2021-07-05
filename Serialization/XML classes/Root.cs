using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace TestTask
{
    [DataContract]
    [XmlRoot("Root")]
    public class Root
    {
        [DataMember]
        [XmlElement("GlobalData")]
        public List<GlobalData> GData { get; set; }

        [DataMember]
        [XmlElement("ModelFile")]
        public List<ModelFile> Models { get; set; }

        public Root()
        {
        }

        public Root(List<ModelFile> models, List<GlobalData> gdata)
        {
            Models.AddRange(models.ToArray());
            GData.AddRange(gdata.ToArray());
        }
    }
}
