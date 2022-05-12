using System.Xml.Serialization;

namespace DicModels.XML;

    [XmlRoot(ElementName="feat")]
    public class FeatXml { 

        [XmlAttribute(AttributeName="att")] 
        public string? AttXml { get; set; } 

        [XmlAttribute(AttributeName="val")] 
        public string? ValXml { get; set; } 
    }