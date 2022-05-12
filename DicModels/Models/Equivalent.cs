using System.ComponentModel.DataAnnotations;

namespace DicModels;

public class Equivalent: BaseModel
{
    public List<Feat> Feats { get; set; }
}