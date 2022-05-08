using System.Xml.Serialization;

namespace DicModels;

[XmlRoot(ElementName = "LexicalResource")]
public class LexicalResourceXml
{
    
    [XmlElement(ElementName = "GlobalInformation")] public GlobalInformationXml GlobalInformation { get; set; }
    
    [XmlElement(ElementName = "Lexicon")] public LexiconXml Lexicon { get; set; }
}