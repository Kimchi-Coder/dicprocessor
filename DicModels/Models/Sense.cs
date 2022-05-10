using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Sense: BaseModel
{
   public List<Feat>? Feats { get; set; } 

   public List<SenseExample>? SenseExample { get; set; } 

   public List<Equivalent>? Equivalent { get; set; } 

   public string? Att { get; set; } 

   public string? Val { get; set; }  
}