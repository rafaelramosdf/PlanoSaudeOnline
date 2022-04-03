using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Api.Controllers.v1.Base;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;

namespace PlanoSaudeOnline.Api.Controllers.v1;

public class OperadoraPlanoSaudeController : BaseController
{
    private readonly ILogger<OperadoraPlanoSaudeController> logger;

    public OperadoraPlanoSaudeController(
        ILogger<OperadoraPlanoSaudeController> logger)
    {
        this.logger = logger;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Post([FromBody] IncluirOperadoraPlanoSaudeRequest request, 
        [FromServices] IIncluirOperadoraPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(request);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<OperadoraPlanoSaude>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get([FromQuery] ConsultarOperadoraPlanoSaudeRequest query, 
        [FromServices] IConsultarOperadoraPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(query);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(OperadoraPlanoSaude), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(string id, 
        [FromServices] IBuscarOperadoraPlanoSaudePorIdHandler handler)
    {
        return await handler.HandleAsync(id);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Put(string id, [FromBody] AlterarOperadoraPlanoSaudeRequest request, 
        [FromServices] IAlterarOperadoraPlanoSaudeHandler handler)
    {
        if (id != request.Id)
            return new BadRequestObjectResult("ID divergente");

        return await handler.HandleAsync(request);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Delete(string id, 
        [FromServices] IExcluirOperadoraPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(id);
    }
}
