using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Lexicon
{
    [Key] public Guid Uuid { get; set; } 
   
    public Feat? Feat { get; set; }
    
    public virtual List<LexicalEntry>? LexicalEntries { get; set; }
}