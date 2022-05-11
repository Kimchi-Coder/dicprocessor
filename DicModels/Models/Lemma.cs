using System.ComponentModel.DataAnnotations;
using DicModels.XML;

namespace DicModels;

public class Lemma: BaseModel
{
   public Feat Feat { get; set; }
}