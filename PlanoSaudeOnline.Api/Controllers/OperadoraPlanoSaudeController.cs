using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

namespace PlanoSaudeOnline.Api.Controllers;

[ApiController]
[Route("api/v1/OperadoraPlanoSaude")]
public class OperadoraPlanoSaudeController : ControllerBase
{
    private readonly ILogger<OperadoraPlanoSaudeController> Logger;

    public OperadoraPlanoSaudeController(ILogger<OperadoraPlanoSaudeController> Logger)
    {
        this.Logger = Logger;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public IActionResult Post([FromBody] IncluirOperadoraPlanoSaudeRequest request, [FromServices] IMediator mediator)
    {
        var result = mediator.Send(request).Result;
        return Created($"OperadoraPlanoSaude", result); //Created($"OperadoraPlanoSaude/{result.Id}", result);
    }

    //[HttpGet]
    //[ProducesResponseType(typeof(IEnumerable<OperadoraPlanoSaude>), StatusCodes.Status200OK)]
    //[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    //public IActionResult Get([FromQuery] int? page, [FromQuery] int? limit)
    //{
    //    var result = CrudUseCase.Listar(page, limit);
    //    return Ok(result);
    //}

    //[HttpGet("{id}")]
    //[ProducesResponseType(typeof(OperadoraPlanoSaude), StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status404NotFound)]
    //[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    //public IActionResult Get(string id)
    //{
    //    var result = CrudUseCase.ListarPorId(id);
    //    return Ok(result);
    //}

    //[HttpPut("{id}")]
    //[ProducesResponseType(StatusCodes.Status204NoContent)]
    //[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    //public IActionResult Put(string id, [FromBody] OperadoraPlanoSaude model)
    //{
    //    CrudUseCase.Alterar(id, model);
    //    return NoContent();
    //}

    //[HttpDelete("{id}")]
    //[ProducesResponseType(StatusCodes.Status204NoContent)]
    //[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    //public IActionResult Delete(string id)
    //{
    //    CrudUseCase.Excluir(id);
    //    return NoContent();
    //}
}
