using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Api.Controllers.v1.Base;
using PlanoSaudeOnline.Domain.Cotacao.Handlers.Contracts;
using PlanoSaudeOnline.Domain.Cotacao.Handlers.Requests;

namespace PlanoSaudeOnline.Api.Controllers.v1;

public class CotacaoController : BaseController
{
    private readonly ILogger<CotacaoController> logger;

    public CotacaoController(
        ILogger<CotacaoController> logger)
    {
        this.logger = logger;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Post(
        [FromBody] RealizarCotacaoRequest request, 
        [FromServices] IRealizarCotacaoHandler handler)
    {
        return await handler.HandleAsync(request);
    }
}
