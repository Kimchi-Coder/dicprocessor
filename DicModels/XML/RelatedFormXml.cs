using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName = "RelatedForm")]
public class RelatedFormXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml>? FeatsXml { get; set; } 
}