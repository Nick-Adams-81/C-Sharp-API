using System;
using Microsoft.AspNetCore.Mvc;

namespace CSharpApi.Controllers
{

[Route("api/[controller]")]
[ApiController]
    public class HelloController : ControllerBase
    {

        [HttpGet]
       public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
