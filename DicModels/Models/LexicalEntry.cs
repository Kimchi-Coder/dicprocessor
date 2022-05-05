using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class LexicalEntry
{
   [Key] public Guid uuid { get; set; } 
   
   public List<Feat> Feats { get; set; }
   
   public Lemma Lemma { get; set; }
   
   public WordForm WordForm { get; set; }
   
   public List<Sense> Senses { get; set; }
   
   public Att Att { get; set; }
   
   public Val Val { get; set; }
}
