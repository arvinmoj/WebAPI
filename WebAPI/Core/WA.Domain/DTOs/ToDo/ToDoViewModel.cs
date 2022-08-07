using System.ComponentModel.DataAnnotations;

namespace WA.Domain.DTOs.ToDo;

public class ToDoViewModel : Base.BaseViewModel
{
    public ToDoViewModel() : base()
    {
    }

    [Display(ResourceType = typeof(Resources.ToDoResources),
               Name = nameof(Resources.ToDoResources.Title))]
    public string? Title { get; set; }

    [Display(ResourceType = typeof(Resources.ToDoResources),
           Name = nameof(Resources.ToDoResources.Title))]
    public string? Description { get; set; }

    [Display(ResourceType = typeof(Resources.ToDoResources),
           Name = nameof(Resources.ToDoResources.Title))]
    public Enumerations.ToDo.States? State { get; set; }

}
