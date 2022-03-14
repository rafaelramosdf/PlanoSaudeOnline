using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.UseCases;

namespace PlanoSaudeOnline.Api.Controllers;

[ApiController]
[Route("api/v1/OperadoraPlanoSaude")]
public class OperadoraPlanoSaudeController : ControllerBase
{
    private readonly ILogger<OperadoraPlanoSaudeController> Logger;
    private readonly ICrudOperadoraPlanoSaudeUseCase CrudUseCase;

    public OperadoraPlanoSaudeController(ILogger<OperadoraPlanoSaudeController> Logger,
        ICrudOperadoraPlanoSaudeUseCase CrudUseCase)
    {
        this.Logger = Logger;
        this.CrudUseCase = CrudUseCase;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public IActionResult Post([FromBody] OperadoraPlanoSaude model)
    {
        var result = CrudUseCase.Incluir(model);
        return Created($"OperadoraPlanoSaude/{result.Id}", result);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<OperadoraPlanoSaude>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public IActionResult Get([FromQuery] int? page, [FromQuery] int? limit)
    {
        var result = CrudUseCase.Listar(page, limit);
        return Ok(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(OperadoraPlanoSaude), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public IActionResult Get(string id)
    {
        var result = CrudUseCase.ListarPorId(id);
        return Ok(result);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public IActionResult Put(string id, [FromBody] OperadoraPlanoSaude model)
    {
        CrudUseCase.Alterar(id, model);
        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public IActionResult Delete(string id)
    {
        CrudUseCase.Excluir(id);
        return NoContent();
    }
}
