using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class SenseExample: BaseModel
{
    public List<Feat> Feats { get; set; } 
}