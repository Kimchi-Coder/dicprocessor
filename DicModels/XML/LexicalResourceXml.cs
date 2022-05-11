using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName = "LexicalResource")]
public class LexicalResourceXml
{
    
    [XmlElement(ElementName = "GlobalInformation")] public GlobalInformationXml? GlobalInformationXml { get; set; }
    
    [XmlElement(ElementName = "Lexicon")] public LexiconXml? LexiconXml { get; set; }
}