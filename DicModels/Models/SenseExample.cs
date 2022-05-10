using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class SenseExample: BaseModel
{
    public List<Feat> Feat { get; set; } 
}