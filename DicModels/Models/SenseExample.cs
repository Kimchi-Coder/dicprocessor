using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class SenseExample
{
    [Key] private Guid uuid { get; set; }
    
    public List<Feat> Feat { get; set; } 
}