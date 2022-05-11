using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Sense: BaseModel
{
   public List<Feat>? Feats { get; set; } 

   public List<SenseExample>? SenseExample { get; set; } 

   public List<Equivalent>? Equivalents { get; set; }
   
   public List<Multimedia>? Multimedias { get; set; } 
   
   public List<SenseRelation>? SenseRelations { get; set; } 

   public string? Att { get; set; } 

   public string? Val { get; set; }  
}