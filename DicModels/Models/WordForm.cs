using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class WordForm: BaseModel
{
   public virtual List<Feat>? Feats { get; set; }
}