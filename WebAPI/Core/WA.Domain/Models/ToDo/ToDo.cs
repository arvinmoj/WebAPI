namespace WA.Domain.Models.Base;

public class ToDo : BaseEntity
{
    public ToDo() : base()
    {
    }

    public string? Title { get; set; }
    public string? Description { get; set; }
    public Enumerations.ToDo.States? State { get; set; }

}

