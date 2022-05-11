using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class LexicalEntry: BaseModel
{
   public List<Feat> Feats { get; set; }
   
   public Lemma Lemma { get; set; }
   
   public WordForm WordForm { get; set; }
   
   public List<Sense> Senses { get; set; }
   
   public List<RelatedForm> RelatedForms { get; set; }
   
   public string Att { get; set; }
   
   public string Val { get; set; }
   
}
