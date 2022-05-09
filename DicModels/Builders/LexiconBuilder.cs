using DicModels.XML;

namespace DicModels.Builders;

public class LexiconBuilder
{
    public static List<LexicalEntry> BuildLexicon(LexiconXml l)
    {
        Lexicon lexicon = new();
        
        lexicon.Uuid = Guid.NewGuid();

        //TODO: make sure null is dealt with
        lexicon.Feat = FeatBuilder.BuildFeat(l.Feat);

        lexicon.LexicalEntries = new List<LexicalEntry>();

        //TODO: make sure null is dealt with
        foreach (LexicalEntryXml entry in l.LexicalEntries)
        {
            LexicalEntry newEntry = LexicalEntryBuilder.BuildLexicalEntry(entry);

            lexicon.LexicalEntries.Add(newEntry);
        }
    }
}