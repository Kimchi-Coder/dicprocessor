using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Feat
{
    [Key] public Guid uuid { get; set; }
    
    public Att att { get; set; }
    
    public Val val { get; set; }
}