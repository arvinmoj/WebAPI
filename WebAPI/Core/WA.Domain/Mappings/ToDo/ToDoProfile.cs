namespace Domain.Mappings;

public class ToDoProfile : AutoMapper.Profile
{
    public ToDoProfile() : base()
    {
        CreateMap<DTOs.ToDo.ToDoViewModel, Models.ToDoModel>();
        CreateMap<Models.ToDoModel, DTOs.ToDo.ToDoViewModel>();
    }
}
