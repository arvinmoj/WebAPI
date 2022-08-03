using Microsoft.AspNetCore.Mvc;

namespace WA.API.Controllers;

[ApiController]
[Route("[controller]")]
public class IndexController : ControllerBase
{
    protected ILogger<IndexController> _logger { get; }

    public IndexController(ILogger<IndexController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Index")]
    public IActionResult Get()
    {
        return Ok();
    }
}
