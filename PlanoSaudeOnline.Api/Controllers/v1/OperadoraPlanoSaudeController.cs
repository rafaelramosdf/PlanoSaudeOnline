using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Api.Controllers.v1.Base;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;

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
    public async Task<IActionResult> Post(
        [FromBody] IncluirOperadoraPlanoSaudeRequest request, 
        [FromServices] IIncluirOperadoraPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(request);
    }

    [HttpGet]
    [ProducesResponseType(typeof(PagedQueryResponse<IEnumerable<OperadoraPlanoSaudeResponse>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(
        [FromQuery] ConsultarOperadoraPlanoSaudeRequest query, 
        [FromServices] IConsultarOperadoraPlanoSaudeHandler handler)
    {
        if (query.Limit > 100)
            return new BadRequestObjectResult("O limite de itens por p�gina � de 100 registros");

        return await handler.HandleAsync(query);
    }

    [HttpGet("{id}", Name = nameof(OperadoraPlanoSaude))]
    [ProducesResponseType(typeof(OperadoraPlanoSaudeResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(
        string id, 
        [FromServices] IBuscarOperadoraPlanoSaudePorIdHandler handler)
    {
        return await handler.HandleAsync(id);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Put(
        string id, 
        [FromBody] AlterarOperadoraPlanoSaudeRequest request, 
        [FromServices] IAlterarOperadoraPlanoSaudeHandler handler)
    {
        if (id != request.Id)
            return new BadRequestObjectResult("ID divergente");

        return await handler.HandleAsync(request);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Delete(
        string id, 
        [FromServices] IExcluirOperadoraPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(id);
    }
}
