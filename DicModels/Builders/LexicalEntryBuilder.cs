using DicModels.XML;

namespace DicModels.Builders;

public class LexicalEntryBuilder
{
    public static LexicalEntry BuildLexicalEntry(LexicalEntryXml l)
    {
        LexicalEntry lexicalEntry = new();
        if (l.Val != null)
        {
            lexicalEntry.Id = Int32.Parse(l.Val);
        }
        else
        {
            lexicalEntry.Id = null;
        }

        lexicalEntry.Feats = new List<Feat>();

        foreach (FeatXml featXml in l.FeatsXml)
        {
            Feat newFeat = FeatBuilder.BuildFeat(featXml);
            lexicalEntry.Feats.Add(newFeat);
        }

        lexicalEntry.WordForm = WordFormBuilder.BuildWordForm(l.WordFormXml);

        // use SensesBuilder
        // lexicalEntry.Senses = l.SensesXml

        // return obj
    }
}