namespace WA.Domain.Models.ToDo;

public class ToDoModel : Base.BaseEntity
{
    public ToDoModel() : base()
    {
    }

    public string? Title { get; set; }
    public string? Description { get; set; }
    public Enumerations.ToDo.States? State { get; set; }

}

