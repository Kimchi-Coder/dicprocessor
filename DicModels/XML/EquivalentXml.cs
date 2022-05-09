using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName="Equivalent")]
public class EquivalentXml
{
    [XmlElement(ElementName="feat")] 
    public List<FeatXml>? Feat { get; set; }
}