using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;

namespace PlanoSaudeOnline.Api.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("api/v{api-version:apiVersion}/[controller]")]
public class OperadoraPlanoSaudeController : ControllerBase
{
    private readonly ILogger<OperadoraPlanoSaudeController> logger;

    public OperadoraPlanoSaudeController(
        ILogger<OperadoraPlanoSaudeController> logger)
    {
        this.logger = logger;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Post([FromBody] IncluirOperadoraPlanoSaudeRequest request, [FromServices] IIncluirOperadoraPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(request);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<OperadoraPlanoSaude>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromQuery] ConsultarOperadoraPlanoSaudeRequest query, [FromServices] IConsultarOperadoraPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(query);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(OperadoraPlanoSaude), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get(string id, [FromServices] IBuscarOperadoraPlanoSaudePorIdHandler handler)
    {
        return await handler.HandleAsync(id);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Put(string id, [FromBody] AlterarOperadoraPlanoSaudeRequest request, [FromServices] IAlterarOperadoraPlanoSaudeHandler handler)
    {
        if (id != request.Id)
            return new BadRequestObjectResult("ID divergente");

        return await handler.HandleAsync(request);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Delete(string id, [FromServices] IExcluirOperadoraPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(id);
    }
}
