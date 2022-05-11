using DicModels.XML;

namespace DicModels.Builders;

public class LexicalEntryBuilder
{
    public static LexicalEntry BuildLexicalEntry(LexicalEntryXml l)
    {
        LexicalEntry lexicalEntry = new();
        lexicalEntry.Att = l.AttXml ?? string.Empty;
        lexicalEntry.Val = l.ValXml ?? string.Empty;
        lexicalEntry.Lemma = LemmaBuilder.BuildLemma(l.LemmaXml);
        lexicalEntry.WordForm = WordFormBuilder.BuildWordForm(l.WordFormXml);
        
        lexicalEntry.Feats = new List<Feat>();
        foreach (FeatXml featXml in l.FeatsXml)
        {
            Feat newFeat = FeatBuilder.BuildFeat(featXml);
            lexicalEntry.Feats.Add(newFeat);
        }

        lexicalEntry.Senses = new List<Sense>();
        foreach (SenseXml senseXml in l.SensesXml)
        {
            Sense newSense = SenseBuilder.BuildSense(senseXml);
            lexicalEntry.Senses.Add(newSense);
        }
        lexicalEntry.RelatedForms = new List<RelatedForm>();
        foreach (RelatedFormXml relatedFormXml in l.RelatedFormsXml)
        {
            RelatedForm newRelatedForm = RelatedFormBuilder.BuildRelatedForm(relatedFormXml);
            lexicalEntry.RelatedForms.Add(newRelatedForm);
        }
        return lexicalEntry;
    }
}