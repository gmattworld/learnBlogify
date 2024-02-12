using Microsoft.AspNetCore.Mvc;

namespace Blogify.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    [HttpGet]
    public IActionResult SayHello()
    {
        return Ok("Hello World");
    }
}