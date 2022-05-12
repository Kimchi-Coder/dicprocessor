using DicModels.XML;

namespace DicModels.Builders;

public class LexiconBuilder
{
    public static Lexicon BuildLexicon(LexiconXml l)
    {
        Lexicon lexicon = new();
        
        //TODO: make sure null is dealt with
        lexicon.Feat = FeatBuilder.BuildFeat(l.FeatXml);

        //TODO: make sure null is dealt with
        lexicon.LexicalEntries = new List<LexicalEntry>();
        foreach (LexicalEntryXml entryXml in l.LexicalEntriesXml)
        {
            LexicalEntry newEntry = LexicalEntryBuilder.BuildLexicalEntry(entryXml);
            lexicon.LexicalEntries.Add(newEntry);
        }

        return lexicon;
    }
}