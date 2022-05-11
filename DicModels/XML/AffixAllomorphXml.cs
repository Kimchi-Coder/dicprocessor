using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName = "AffixAllomorph")]
public class AffixAllomorphXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml>? FeatsXml { get; set; }
    
    [XmlElement(ElementName = "FormRepresentation")] public List<FormRepresentationXml>? FormRepresentationsXml { get; set; }
    
    [XmlElement(ElementName = "Condition")] public List<ConditionXml>? ConditionsXml { get; set; }
}