using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Lexicon: BaseModel
{
    public virtual List<LexicalEntry>? LexicalEntries { get; set; }
    public Feat? Feat { get; set; }
    
}