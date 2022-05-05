using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Val
{
    [Key] public Guid uuid { get; set; }
    
    public UInt16 val { get; set; }
}