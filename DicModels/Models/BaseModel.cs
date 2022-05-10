using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DicModels;

public class BaseModel
{
    public BaseModel()
    {
        Uuid = Guid.NewGuid();
        CreatedOn = DateTime.Now;
        UpdatedOn = DateTime.Now;
    }
    
    [Key]
    public Guid Uuid { get; set; }
    
    [JsonIgnore]
    public DateTime CreatedOn {get; set; }
    
    [JsonIgnore]
    public DateTime UpdatedOn {get; set; }
    
    [JsonIgnore]
    public Boolean IsDeleted {get; set; }
    
    
}