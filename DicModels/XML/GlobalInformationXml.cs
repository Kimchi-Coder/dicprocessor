using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName="GlobalInformation")]
public class GlobalInformationXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml>? FeatsXml { get; set; } 
    
}