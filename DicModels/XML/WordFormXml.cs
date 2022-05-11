using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName="WordForm")]
public class WordFormXml { 

    [XmlElement(ElementName="feat")] 
    public List<FeatXml>? FeatsXml { get; set; } 
}