using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Equivalent: BaseModel
{
    public virtual List<Feat>? Feats { get; set; }
}