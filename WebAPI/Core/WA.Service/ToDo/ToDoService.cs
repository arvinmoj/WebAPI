using Data;
using DTOs.ToDo;
using AutoMapper;

namespace Service.ToDo;

public interface IToDoService
{
    // Get Async
    Task<IEnumerable<ToDoViewModel>> GetByIdAsync(Guid id);

    // Get All Async
    Task<IEnumerable<ToDoViewModel>> GetAllAsync();

    // Add Async
    Task<IEnumerable<ToDoViewModel>> AddAsync(ToDoViewModel toDoViewModel);

    // Edit Async
    Task<IEnumerable<ToDoViewModel>> EditAsync(ToDoViewModel toDoViewModel);

    // Delete By Id Async
    Task<IEnumerable<ToDoViewModel>> DeleteByIdAsync(Guid id);

    // Delete Async
    Task<IEnumerable<ToDoViewModel>> DeleteAsync(ToDoViewModel toDoViewModel);
}

public class ToDoService : Base.BaseService, IToDoService
{
    #region Constructor
    public ToDoService(IUnitOfWork unitOfWork, Mapper mapper) : base(unitOfWork, mapper)
    {
    }
    #endregion /Constructor

    #region GetAsync
    public async Task<IEnumerable<ToDoViewModel>> GetByIdAsync(Guid id)
    {
        try
        {
            var result =
                await UnitOfWork.ToDoRepository.GetByIdAsync(id: id);

            var toDoViewModel = Mapper.Map<IEnumerable<ToDoViewModel>>(source: result);

            return toDoViewModel;
        }
        catch (Exception)
        {
            return null;
        }
    }
    #endregion /GetAsync

    #region GetAllAsync
    public async Task<IEnumerable<ToDoViewModel>> GetAllAsync()
    {
        try
        {
            var result =
                await UnitOfWork.ToDoRepository.GetAllAsync();

            var toDoViewModel = Mapper.Map<IEnumerable<ToDoViewModel>>(source: result);

            return toDoViewModel;
        }
        catch (Exception)
        {
            return null;
        }
    }
    #endregion GetAllAsync

    #region AddAsync
    public async Task<IEnumerable<ToDoViewModel>> AddAsync(ToDoViewModel viewModel)
    {
        try
        {
            var toDoModel =
               Mapper.Map<Models.ToDoModel>(source: viewModel);

            await UnitOfWork.ToDoRepository.InsertAsync(toDoModel);
            await UnitOfWork.SaveAsync();

            var todoViewModel =
               Mapper.Map<IEnumerable<ToDoViewModel>>(source: toDoModel);

            return todoViewModel;
        }
        catch (Exception)
        {
            return null;
        }
    }
    #endregion /AddAsync

    #region EditAsync
    public async Task<IEnumerable<ToDoViewModel>> EditAsync(ToDoViewModel viewModel)
    {
        try
        {
            var toDoModel =
            Mapper.Map<Models.ToDoModel>(source: viewModel);

            await UnitOfWork.ToDoRepository.UpdateAsync(toDoModel);
            await UnitOfWork.SaveAsync();

            var todoViewModel =
               Mapper.Map<IEnumerable<ToDoViewModel>>(source: toDoModel);

            return todoViewModel;
        }
        catch (Exception)
        {
            return null;
        }
    }
    #endregion /EditAsync

    #region DeleteByIdAsync
    public async Task<IEnumerable<ToDoViewModel>> DeleteByIdAsync(Guid id)
    {
        try
        {
            var result =
                await UnitOfWork.ToDoRepository.DeleteByIdAsync(id: id);

            var toDoViewModel = Mapper.Map<IEnumerable<ToDoViewModel>>(source: result);

            return toDoViewModel;
        }
        catch (Exception)
        {
            return null;
        }
    }
    #endregion /DeleteByIdAsync

    #region DeleteAsync
    public async Task<IEnumerable<ToDoViewModel>> DeleteAsync(ToDoViewModel viewModel)
    {
        try
        {
            var toDoModel =
               Mapper.Map<Models.ToDoModel>(source: viewModel);

            await UnitOfWork.ToDoRepository.DeleteAsync(toDoModel);
            await UnitOfWork.SaveAsync();

            var todoViewModel =
               Mapper.Map<IEnumerable<ToDoViewModel>>(source: toDoModel);

            return todoViewModel;
        }
        catch (Exception)
        {
            return null;
        }
    }
    #endregion /DeleteByIdAsync
}
