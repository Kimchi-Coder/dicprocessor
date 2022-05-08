using System.Xml.Serialization;

namespace DicModels;

[XmlRoot(ElementName="GlobalInformation")]
public class GlobalInformationXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml> Feats { get; set; } 
    
}