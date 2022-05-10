using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName="WordForm")]
public class WordFormXml { 

    [XmlElement(ElementName="feat")] 
    public List<FeatXml>? Feats { get; set; } 
}