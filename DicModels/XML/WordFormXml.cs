using System.Xml.Serialization;

namespace DicModels;

[XmlRoot(ElementName="WordForm")]
public class WordFormXml { 

    [XmlElement(ElementName="feat")] 
    public List<FeatXml> Feat { get; set; } 
}