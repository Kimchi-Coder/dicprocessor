using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Feat: BaseModel
{
    public string? Att { get; set; }
    
    public string? Val { get; set; }
}