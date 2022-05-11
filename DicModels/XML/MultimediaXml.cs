using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName = "Multimedia")]
public class MultimediaXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml>? FeatsXml { get; set; } 
 
}