using System.Xml.Serialization;

namespace DicModels;


[XmlRoot(ElementName="Lemma")]
public class LemmaXml { 

    [XmlElement(ElementName="feat")] 
    public FeatXml FeatXml { get; set; } 
}
