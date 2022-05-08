using System.Xml.Serialization;

namespace DicModels;

[XmlRoot(ElementName = "FormRepresentation")]
public class FormRepresentationXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml> Feats { get; set; }
}