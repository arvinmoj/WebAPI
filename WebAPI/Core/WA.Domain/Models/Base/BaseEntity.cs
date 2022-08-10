using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Base;

public class BaseEntity : Object
{
    public BaseEntity() : base()
    {
        Id = Guid.NewGuid();
        InsertDateTime = Utility.DateTime.Now;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Display(ResourceType = typeof(Resources.DataDictionary),
             Name = nameof(Resources.DataDictionary.Id))]
    public Guid Id { get; set; }

    [Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.InsertDateTime))]
    public DateTime InsertDateTime { get; set; }
}
