using Microsoft.AspNetCore.Mvc;
using Portifolio.Domain.Entities;

namespace Portfolio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var lista = new List<Project>
            {
                new Project { Id = 1, Title = "Projeto Teste", Description = "Funcionando!" }
            };

            return Ok(lista);
        }
    }
}
