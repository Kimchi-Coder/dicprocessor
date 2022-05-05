using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Sense
{
   [Key] private Guid uuid { get; set; }
   
   public List<Feat> Feat { get; set; } 

   public List<SenseExample> SenseExample { get; set; } 

   public List<Equivalent> Equivalent { get; set; } 

   public string Att { get; set; } 

   public int Val { get; set; }  
}