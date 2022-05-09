using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Feat
{
    [Key] public Guid Uuid { get; set; }
    
    public string Att { get; set; }
    
    public string Val { get; set; }
}