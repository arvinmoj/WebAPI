namespace WA.Domain.DTO.ToDo;

public class ToDoViewModel : Base.BaseViewModel
{
    public ToDoViewModel() : base()
    {
    }

    public string? Title { get; set; }
    public string? Description { get; set; }
    public Enumeration.ToDo.States? State { get; set; }

}
