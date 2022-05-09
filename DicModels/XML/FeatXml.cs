using System.Xml.Serialization;

namespace DicModels.XML;

    [XmlRoot(ElementName="feat")]
    public class FeatXml { 

        [XmlAttribute(AttributeName="att")] 
        public string? Att { get; set; } 

        [XmlAttribute(AttributeName="val")] 
        public string? Val { get; set; } 
    }