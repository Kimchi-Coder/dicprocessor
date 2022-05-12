using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName="Lexicon")]
public class LexiconXml
{
    [XmlElement(ElementName = "LexicalEntry")] public List<LexicalEntryXml>? LexicalEntriesXml { get; set; }
    
    [XmlElement(ElementName = "feat")] public FeatXml? FeatXml { get; set; }
}