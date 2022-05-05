using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Lemma
{
   [Key] public Guid uuid { get; set; }
   
   public FeatXml FeatXml { get; set; }
}