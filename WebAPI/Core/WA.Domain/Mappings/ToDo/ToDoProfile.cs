namespace WA.Domain.Mappings.ToDo;

public class ToDoProfile : AutoMapper.Profile
{
    public ToDoProfile() : base()
    {
        CreateMap<DTOs.ToDo.ToDoViewModel, Models.ToDo.ToDoModel>();
        CreateMap<Models.ToDo.ToDoModel, DTOs.ToDo.ToDoViewModel>();
    }
}
