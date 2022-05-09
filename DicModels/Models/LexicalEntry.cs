using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class LexicalEntry
{
   [Key] public Guid Uuid { get; set; } 
   
   public int? Id { get; set; }
   
   public List<Feat> Feats { get; set; }
   
   public Lemma Lemma { get; set; }
   
   public WordForm WordForm { get; set; }
   
   public List<Sense> Senses { get; set; }
   
}
