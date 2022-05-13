using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class SenseExample: BaseModel
{
    public virtual List<Feat> Feats { get; set; } 
}