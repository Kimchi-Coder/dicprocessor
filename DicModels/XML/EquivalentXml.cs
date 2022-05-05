using System.Xml.Serialization;

namespace DicModels;

[XmlRoot(ElementName="Equivalent")]
public class EquivalentXml
{
    [XmlElement(ElementName="feat")] 
    public List<FeatXml> Feat { get; set; }
}