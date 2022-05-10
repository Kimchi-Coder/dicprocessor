using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName="Sense")]
public class SenseXml { 

    [XmlElement(ElementName="feat")] 
    public List<FeatXml>? FeatsXml { get; set; } 

    [XmlElement(ElementName="SenseExample")] 
    public List<SenseExampleXml>? SenseExamples { get; set; } 

    [XmlElement(ElementName="Equivalent")] 
    public List<EquivalentXml>? Equivalents { get; set; } 

    [XmlAttribute(AttributeName="att")] 
    public string? Att { get; set; } 

    [XmlAttribute(AttributeName="val")] 
    public string? Val { get; set; } 
}
