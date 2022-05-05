using System.Xml.Serialization;

namespace DicModels;

[XmlRoot(ElementName="SenseExample")]
public class SenseExampleXml { 

    [XmlElement(ElementName="feat")] 
    public List<FeatXml> Feat { get; set; } 
}
