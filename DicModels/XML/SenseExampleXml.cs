using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName="SenseExample")]
public class SenseExampleXml { 

    [XmlElement(ElementName="feat")] 
    public List<FeatXml>? FeatsXml { get; set; } 
}
