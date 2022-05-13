using System.ComponentModel.DataAnnotations;
using DicModels.XML;

namespace DicModels;

public class Lemma: BaseModel
{
   public virtual Feat Feat { get; set; }
}