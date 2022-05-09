using System.ComponentModel.DataAnnotations;
using DicModels.XML;

namespace DicModels;

public class Lemma
{
   [Key] public Guid uuid { get; set; }
   
   public FeatXml FeatXml { get; set; }
}