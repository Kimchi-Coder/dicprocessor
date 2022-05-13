using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class LexicalEntry: BaseModel
{
   public virtual List<Feat> Feats { get; set; }
   
   public virtual Lemma Lemma { get; set; }
   
   public virtual WordForm WordForm { get; set; }
   
   public virtual List<Sense> Senses { get; set; }
   
   public virtual List<RelatedForm> RelatedForms { get; set; }
   
   public string Att { get; set; }
   
   public string Val { get; set; }
   
}
