using System.Xml.Serialization;

namespace DicModels;

[XmlRoot(ElementName = "RelatedForm")]
public class RelatedFormXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml> Feats { get; set; } 
}