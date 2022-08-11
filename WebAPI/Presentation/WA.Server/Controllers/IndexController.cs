using Data;
using DTOs.ToDo;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
namespace WA.API.Controllers;

[ApiController]
[Route("[controller]")]
public class IndexController : Infrastructure.BaseApiControllerWithDatabase
{
    public IndexController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
    {
        Mapper = mapper;
    }
    protected IMapper Mapper { get; }


    [HttpGet(template: "GetById")]
    public async Task<ActionResult<IEnumerable<Models.ToDoModel>>> GetByIdAsync(Guid id)
    {
        var result =
            await UnitOfWork.ToDoRepository.GetByIdAsync(id);

        return Ok(value: result);
    }

    [HttpGet]
    public
    async Task<ActionResult<IEnumerable<Models.ToDoModel>>> GetAllAsync()
    {
        var result =
            await UnitOfWork.ToDoRepository.GetAllAsync();

        return Ok(value: result);
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<Models.ToDoModel>>> PostAsync(ToDoViewModel viewModel)
    {
        try
        {
           Models.ToDoModel toDoModel=
                Mapper.Map<Models.ToDoModel>(source: viewModel);

            await UnitOfWork.ToDoRepository.InsertAsync(toDoModel);
            await UnitOfWork.SaveAsync();

            return Ok(value: toDoModel);
        }
        catch (System.Exception)
        {
            return Ok(value: null);
        }
    }

    [HttpPut]
    public async Task<ActionResult<IEnumerable<Models.ToDoModel>>> PutAsync(ToDoViewModel viewModel)
    {
        try
        {
            Models.ToDoModel toDoModel=
                Mapper.Map<Models.ToDoModel>(source: viewModel);

            await UnitOfWork.ToDoRepository.UpdateAsync(toDoModel);
            await UnitOfWork.SaveAsync();

            return Ok(value: toDoModel);
        }
        catch (System.Exception)
        {
            return Ok(value: null);
        }
    }

    [HttpDelete(template: "DeleteByID")]
    public async Task<ActionResult<IEnumerable<Models.ToDoModel>>> DeleteByIDAsync(Guid id)
    {
        try
        {
            var result =
                await UnitOfWork.ToDoRepository.DeleteByIdAsync(id);
            await UnitOfWork.SaveAsync();

            return Ok(value: result);
        }
        catch (System.Exception)
        {
            return Ok(value: null);
        }
    }

    [HttpDelete]
    public async Task<ActionResult<IEnumerable<Models.ToDoModel>>> DeleteAsync(ToDoViewModel viewModel)
    {
        try
        {
            Models.ToDoModel toDoModel=
                Mapper.Map<Models.ToDoModel>(source: viewModel);

            await UnitOfWork.ToDoRepository.DeleteAsync(toDoModel);
            await UnitOfWork.SaveAsync();

            return Ok(value: toDoModel);
        }
        catch (System.Exception)
        {
            return Ok(value: null);
        }
    }
}
