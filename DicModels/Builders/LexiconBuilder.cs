using DicModels.XML;

namespace DicModels.Builders;

public class LexiconBuilder
{
    public static Lexicon BuildLexicon(LexiconXml l)
    {
        Lexicon lexicon = new();
        
        //TODO: make sure null is dealt with
        lexicon.Feat = FeatBuilder.BuildFeat(l.Feat);

        lexicon.LexicalEntries = new List<LexicalEntry>();

        //TODO: make sure null is dealt with
        foreach (LexicalEntryXml entryXml in l.LexicalEntries)
        {
            LexicalEntry newEntry = LexicalEntryBuilder.BuildLexicalEntry(entryXml);

            lexicon.LexicalEntries.Add(newEntry);
        }

        return lexicon;
    }
}