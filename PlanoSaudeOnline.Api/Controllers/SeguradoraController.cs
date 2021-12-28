using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Services.Contracts;

namespace PlanoSaudeOnline.Api.Controllers
{
    [ApiController]
    [Route("api/v1/seguradoras")]
    public class SeguradoraController : ControllerBase
    {
        private readonly ILogger<SeguradoraController> logger;
        private readonly ISeguradoraService seguradoraService;

        public SeguradoraController(ILogger<SeguradoraController> logger,
            ISeguradoraService seguradoraService)
        {
            this.logger = logger;
            this.seguradoraService = seguradoraService;
        }

        [HttpPost] 
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public IActionResult Post([FromBody] Seguradora model)
        {
            var result = seguradoraService.Incluir(model);
            return Created($"seguradoras/{result.Id}", result);
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Seguradora>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            var result = seguradoraService.ListarTodos();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Seguradora), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public IActionResult Get(string id)
        {
            var result = seguradoraService.ListarPorId(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public IActionResult Put(string id, [FromBody] Seguradora model)
        {
            seguradoraService.Alterar(id, model);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public IActionResult Delete(string id)
        {
            seguradoraService.Excluir(id);
            return NoContent();
        }
    }
}