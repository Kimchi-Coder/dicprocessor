using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName = "FormRepresentation")]
public class FormRepresentationXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml>? FeatsXml { get; set; }
}