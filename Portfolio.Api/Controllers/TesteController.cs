using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Funcionando!");
    }
}
