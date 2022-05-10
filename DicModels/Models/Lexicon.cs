using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Lexicon: BaseModel
{
    public Feat? Feat { get; set; }
    
    public virtual List<LexicalEntry>? LexicalEntries { get; set; }
}