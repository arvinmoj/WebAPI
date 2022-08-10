using Models;
using Microsoft.AspNetCore.Mvc;
using Data;
namespace WA.API.Controllers;

[ApiController]
[Route("[controller]")]
public class IndexController : Infrastructure.BaseApiControllerWithDatabase
{

    public IndexController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    [HttpGet("GetAll")]
    public
    async Task<ActionResult<IEnumerable<Models.ToDoModel>>> GetAllAsync()
    {
        var result =
            await UnitOfWork.ToDoRepository.GetAllAsync();

        return Ok(value: result);
    }

    [HttpPost]
    public
    async Task<ActionResult<Models.ToDoModel>> PostAsync(DTOs.ToDo.ToDoViewModel viewModel)
    {
        try
        {
          var newEntity =
            new Models.ToDoModel
            {
                Title = viewModel.Title,
                State = viewModel.State,
                Description = viewModel.Description,
            };   

            await UnitOfWork.ToDoRepository.InsertAsync(newEntity);
            await UnitOfWork.SaveAsync();

            return Ok(value: newEntity);
        }
        catch (System.Exception)
        {
            return Ok(value: null);
        }
    }
}
