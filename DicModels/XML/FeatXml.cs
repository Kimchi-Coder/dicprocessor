using System.Xml.Serialization;

namespace DicModels;

    [XmlRoot(ElementName="feat")]
    public class FeatXml { 

        [XmlAttribute(AttributeName="att")] 
        public string Att { get; set; } 

        [XmlAttribute(AttributeName="val")] 
        public int Val { get; set; } 
    }