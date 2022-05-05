using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Att
{
    [Key] public Guid uuid { get; set; }
    
    public UInt16 val { get; set; }
}