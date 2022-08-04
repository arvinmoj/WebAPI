namespace WA.Domain.DTOs.ToDo;

public class ToDoViewModel : Base.BaseViewModel
{
    public ToDoViewModel() : base()
    {
    }

    public string? Title { get; set; }
    public string? Description { get; set; }
    public Enumerations.ToDo.States? State { get; set; }

}
