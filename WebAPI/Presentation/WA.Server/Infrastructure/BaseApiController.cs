namespace Infrastructure;

[Microsoft.AspNetCore.Mvc.ApiController]
[Microsoft.AspNetCore.Mvc.Route("[controller]")]
[Microsoft.AspNetCore.Mvc.Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
public class BaseApiController : Microsoft.AspNetCore.Mvc.Controller
{
    public BaseApiController() : base()
    {

    }
}
