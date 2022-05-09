using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName = "LexicalResource")]
public class LexicalResourceXml
{
    
    [XmlElement(ElementName = "GlobalInformation")] public GlobalInformationXml? GlobalInformation { get; set; }
    
    [XmlElement(ElementName = "Lexicon")] public LexiconXml? Lexicon { get; set; }
}