namespace WA.Domain.Entity.Base;

public class ToDo : BaseEntity
{
    public ToDo() : base()
    {
    }

    public string? Title { get; set; }
    public string? Description { get; set; }
    public Enumeration.ToDo.States? State { get; set; }

}

