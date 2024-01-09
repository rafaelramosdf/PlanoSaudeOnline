using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Api.Controllers.v1.Base;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Entities;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Responses;

namespace PlanoSaudeOnline.Api.Controllers.v1;

public class ValorComercialMensalidadeController : BaseController
{
    private readonly ILogger<ValorComercialMensalidadeController> logger;

    public ValorComercialMensalidadeController(
        ILogger<ValorComercialMensalidadeController> logger)
    {
        this.logger = logger;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Post(
        [FromBody] IncluirValorComercialMensalidadeRequest request, 
        [FromServices] IIncluirValorComercialMensalidadeHandler handler)
    {
        return await handler.HandleAsync(request);
    }

    [HttpGet]
    [ProducesResponseType(typeof(PagedQueryResponse<IEnumerable<ValorComercialMensalidadeResponse>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(
        [FromQuery] ConsultarValorComercialMensalidadeRequest query, 
        [FromServices] IConsultarValorComercialMensalidadeHandler handler)
    {
        if (query.Limit > 100)
            return new BadRequestObjectResult("O limite de itens por página é de 100 registros");

        return await handler.HandleAsync(query);
    }

    [HttpGet("{id}", Name = nameof(ValorComercialMensalidade))]
    [ProducesResponseType(typeof(ValorComercialMensalidadeResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(
        string id, 
        [FromServices] IBuscarValorComercialMensalidadePorIdHandler handler)
    {
        return await handler.HandleAsync(id);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Put(
        string id, 
        [FromBody] AlterarValorComercialMensalidadeRequest request, 
        [FromServices] IAlterarValorComercialMensalidadeHandler handler)
    {
        if (id != request.Id)
            return new BadRequestObjectResult("ID divergente");

        return await handler.HandleAsync(request);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Delete(
        string id, 
        [FromServices] IExcluirValorComercialMensalidadeHandler handler)
    {
        return await handler.HandleAsync(id);
    }
}
