using System.Xml.Serialization;

namespace DicModels.XML;

[XmlRoot(ElementName="Lexicon")]
public class LexiconXml
{
    [XmlElement(ElementName = "LexicalEntry")] public List<LexicalEntryXml>? LexicalEntries { get; set; }
    
    [XmlElement(ElementName = "feat")] public FeatXml? Feat { get; set; }
}