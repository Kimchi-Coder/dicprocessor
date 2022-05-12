using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName = "Affix")]
public class AffixXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml>? FeatsXml { get; set; }
    
    [XmlElement(ElementName = "AffixAllomorph")] public List<AffixAllomorphXml>? AffixAllomorphsXml { get; set; }
    
    // [XmlElement(ElementName = "GrammaticalFeatures")] public List<GrammaticalFeaturesXml>? GrammaticalFeaturesXml { get; set; }
    
}