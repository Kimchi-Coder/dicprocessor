using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Sense: BaseModel
{
   public virtual List<Feat>? Feats { get; set; } 

   public virtual List<SenseExample>? SenseExample { get; set; } 

   public virtual List<Equivalent>? Equivalents { get; set; }
   
   public virtual List<Multimedia>? Multimedias { get; set; } 
   
   public virtual List<SenseRelation>? SenseRelations { get; set; } 

   public string? Att { get; set; } 

   public string? Val { get; set; }  
}