using DicModels.XML;

namespace DicModels.Builders;

public class LexicalEntryBuilder
{
    public static LexicalEntry BuildLexicalEntry(LexicalEntryXml l)
    {
        LexicalEntry lexicalEntry = new();
        lexicalEntry.Att = l.AttXml ?? string.Empty;
        lexicalEntry.Val = l.ValXml ?? string.Empty;
        if (l.LemmaXml != null) lexicalEntry.Lemma = LemmaBuilder.BuildLemma(l.LemmaXml);
        if (l.WordFormXml != null) lexicalEntry.WordForm = WordFormBuilder.BuildWordForm(l.WordFormXml);

        lexicalEntry.Feats = new List<Feat>();
        if (l.FeatsXml != null)
            foreach (Feat newFeat in l.FeatsXml.Select(featXml => FeatBuilder.BuildFeat(featXml)))
            {
                lexicalEntry.Feats.Add(newFeat);
            }

        lexicalEntry.Senses = new List<Sense>();
        if (l.SensesXml != null)
            foreach (Sense newSense in l.SensesXml.Select(senseXml => SenseBuilder.BuildSense(senseXml)))
            {
                lexicalEntry.Senses.Add(newSense);
            }

        lexicalEntry.RelatedForms = new List<RelatedForm>();
        if (l.RelatedFormsXml == null) return lexicalEntry;
        foreach (RelatedForm newRelatedForm in l.RelatedFormsXml.Select(relatedFormXml => RelatedFormBuilder.BuildRelatedForm(relatedFormXml)))
        {
            lexicalEntry.RelatedForms.Add(newRelatedForm);
        }

        return lexicalEntry;
    }
}