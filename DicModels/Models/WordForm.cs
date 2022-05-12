using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class WordForm: BaseModel
{
   public List<Feat> Feats { get; set; }
}