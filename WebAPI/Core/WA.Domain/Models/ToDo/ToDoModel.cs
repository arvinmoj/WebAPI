using System.ComponentModel.DataAnnotations;

namespace WA.Domain.Models.ToDo;

public class ToDoModel : Base.BaseEntity
{
    public ToDoModel() : base()
    {
    }

    [Display(ResourceType = typeof(Resources.ToDoResources),
            Name = nameof(Resources.ToDoResources.Title))]
    public string? Title { get; set; }

    [Display(ResourceType = typeof(Resources.ToDoResources),
        Name = nameof(Resources.ToDoResources.Description))]
    public string? Description { get; set; }

    [Display(ResourceType = typeof(Resources.ToDoResources),
        Name = nameof(Resources.ToDoResources.State))]
    public Enumerations.ToDo.States? State { get; set; }

}

