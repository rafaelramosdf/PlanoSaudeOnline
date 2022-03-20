using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Domain.Entities;
using PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

namespace PlanoSaudeOnline.Api.Controllers;

[ApiController]
[Route("api/v1/OperadoraPlanoSaude")]
public class OperadoraPlanoSaudeController : ControllerBase
{
    private readonly IMediator mediator;
    private readonly ILogger<OperadoraPlanoSaudeController> logger;

    public OperadoraPlanoSaudeController(
        IMediator mediator,
        ILogger<OperadoraPlanoSaudeController> logger)
    {
        this.mediator = mediator;
        this.logger = logger;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Post([FromBody] IncluirOperadoraPlanoSaudeCommand request)
    {
        var result = await mediator.Send(request);
        return Created($"OperadoraPlanoSaude/{result?.Id}", result);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<OperadoraPlanoSaude>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromQuery] ConsultarOperadoraPlanoSaudeQuery query)
    {
        var result = await mediator.Send(query);
        return Ok(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(OperadoraPlanoSaude), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get(string id)
    {
        var query = new ConsultarOperadoraPlanoSaudeQuery(id);

        var result = await mediator.Send(query);
        return Ok(result);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Put(string id, [FromBody] AlterarOperadoraPlanoSaudeCommand request)
    {
        await mediator.Send(request);
        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Delete(string id)
    {
        var request = new ExcluirOperadoraPlanoSaudeCommand { Id = id };
        await mediator.Send(request);
        return NoContent();
    }
}
