using DicModels.XML;

namespace DicModels.Builders;

public class LexicalEntryBuilder
{
    public static LexicalEntry BuildLexicalEntry(LexicalEntryXml l)
    {
        LexicalEntry lexicalEntry = new();
        lexicalEntry.Uuid = Guid.NewGuid();
        if (l.Val != null)
        {
            lexicalEntry.Id = Int32.Parse(l.Val);
        }
        else
        {
            lexicalEntry.Id = null;
        }
        // use FeatBuilder
        // lexicalEntry.Feats = l.FeatsXml
        
        // use WordFormBuilder
        // lexicalEntry.WordForm = l.WordFormXml
        
        // use SensesBuilder
        // lexicalEntry.Senses = l.SensesXml
        
        // return obj
    }
}