using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Api.Controllers.v1.Base;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.PlanoSaude.Entities;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Responses;

namespace PlanoSaudeOnline.Api.Controllers.v1;

public class PlanoSaudeController : BaseController
{
    private readonly ILogger<PlanoSaudeController> logger;

    public PlanoSaudeController(
        ILogger<PlanoSaudeController> logger)
    {
        this.logger = logger;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Post(
        [FromBody] IncluirPlanoSaudeRequest request, 
        [FromServices] IIncluirPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(request);
    }

    [HttpGet]
    [ProducesResponseType(typeof(PagedQueryResponse<IEnumerable<PlanoSaudeResponse>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(
        [FromQuery] ConsultarPlanoSaudeRequest query, 
        [FromServices] IConsultarPlanoSaudeHandler handler)
    {
        if (query.Limit > 100)
            return new BadRequestObjectResult("O limite de itens por página é de 1000 registros");

        return await handler.HandleAsync(query);
    }

    [HttpGet("{id}", Name = nameof(PlanoSaude))]
    [ProducesResponseType(typeof(PlanoSaudeResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(
        string id, 
        [FromServices] IBuscarPlanoSaudePorIdHandler handler)
    {
        return await handler.HandleAsync(id);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Put(
        string id, 
        [FromBody] AlterarPlanoSaudeRequest request, 
        [FromServices] IAlterarPlanoSaudeHandler handler)
    {
        if (id != request.Id)
            return new BadRequestObjectResult("ID divergente");

        return await handler.HandleAsync(request);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Delete(
        string id, 
        [FromServices] IExcluirPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync(id);
    }

    [HttpPost("Atualizacoes/Tags")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> AtualizacoesTags(
        [FromServices] IAtualizarTagsPlanoSaudeHandler handler)
    {
        return await handler.HandleAsync();
    }
}
