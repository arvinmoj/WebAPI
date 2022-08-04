namespace WA.Domain.Models.Base;

public class BaseEntity : Object
{
    public BaseEntity() : base()
    {
        Id = new Guid();
        InsertTime =  DateTime.Now;
    }

    public Guid Id { get; set; }
    public DateTime InsertTime { get; set; }
}
