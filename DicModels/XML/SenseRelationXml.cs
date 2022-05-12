using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName = "SenseRelation")]
public class SenseRelationXml
{
    
    [XmlElement(ElementName = "feat")] public List<FeatXml>? FeatsXml { get; set; } 
}