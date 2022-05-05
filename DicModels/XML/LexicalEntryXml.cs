using System.Xml.Serialization;

namespace DicModels;

[XmlRoot(ElementName = "LexicalEntry")]
public class LexicalEntryXml
{
    [XmlElement(ElementName = "feat")] public List<FeatXml> Feat { get; set; }

    [XmlElement(ElementName = "Lemma")] public LemmaXml LemmaXml { get; set; }

    [XmlElement(ElementName = "WordForm")] public WordFormXml WordFormXml { get; set; }

    [XmlElement(ElementName = "Sense")] public List<SenseXml> Sense { get; set; }

    [XmlAttribute(AttributeName = "att")] public string Att { get; set; }

    [XmlAttribute(AttributeName = "val")] public int Val { get; set; }
}



