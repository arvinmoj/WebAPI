using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WA.Domain.Models.Base;

public class BaseEntity : Object
{
    public BaseEntity() : base()
    {
        Id = new Guid();
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
