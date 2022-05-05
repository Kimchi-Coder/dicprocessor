using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class WordForm
{
   [Key] private Guid uuid { get; set; }
   
   public List<Feat> Feats { get; set; }
}