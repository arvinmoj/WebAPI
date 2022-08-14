using Data;
using DTOs.ToDo;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
namespace WA.API.Controllers;

[ApiController]
[Route("[controller]")]
public class IndexController : Infrastructure.BaseApiControllerWithDatabase
{
    public IndexController(IUnitOfWork unitOfWork, IMapper mapper, Utility.Logging.ILogger<IndexController> logger) : base(unitOfWork)
    {
        Mapper = mapper;
        Logger = logger;
    }

    protected IMapper Mapper { get; }
    protected Utility.Logging.ILogger<IndexController> Logger { get; }


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


        // **************************************************

        Exception innerException = new System.Exception(message: "Inner Exception Message (1)");

        Exception exception = new System.Exception(message: "Exception Message (1)", innerException: innerException);

        System.Collections.Hashtable hashtable = new System.Collections.Hashtable();

        hashtable.Add(key: "Key1", value: "Value1");

        hashtable.Add(key: "Key2", value: "Value2");

        Logger.LogCritical(exception: exception, message: "Fatal 1", parameters: hashtable);

        // **************************************************
        var result =
            await UnitOfWork.ToDoRepository.GetAllAsync();

        return Ok(value: result);
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<Models.ToDoModel>>> PostAsync(ToDoViewModel viewModel)
    {
        try
        {
            Models.ToDoModel toDoModel =
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
            Models.ToDoModel toDoModel =
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
            Models.ToDoModel toDoModel =
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
