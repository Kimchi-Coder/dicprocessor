using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName="Sense")]
public class SenseXml { 

    [XmlElement(ElementName="feat")] 
    public List<FeatXml>? FeatsXml { get; set; } 

    [XmlElement(ElementName="SenseExample")] 
    public List<SenseExampleXml>? SenseExamplesXml { get; set; } 

    [XmlElement(ElementName="Equivalent")] 
    public List<EquivalentXml>? EquivalentsXml { get; set; } 

    [XmlElement(ElementName="Multimedia")] 
    public List<MultimediaXml>? MultimediasXml { get; set; } 
    
    [XmlElement(ElementName="SenseRelation")] 
    public List<SenseRelationXml>? SenseRelationsXml { get; set; } 
    
    [XmlAttribute(AttributeName="att")] 
    public string? AttXml { get; set; } 

    [XmlAttribute(AttributeName="val")] 
    public string? ValXml { get; set; } 
}
