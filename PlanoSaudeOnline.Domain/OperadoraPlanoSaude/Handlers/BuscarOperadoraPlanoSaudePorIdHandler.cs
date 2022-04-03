using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class BuscarOperadoraPlanoSaudePorIdHandler : IBuscarOperadoraPlanoSaudePorIdHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public BuscarOperadoraPlanoSaudePorIdHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<IActionResult> HandleAsync(string request)
    {
        Console.WriteLine("Handle BuscarOperadoraPlanoSaudePorIdHandler executed!");
        return new OkObjectResult("Handle BuscarOperadoraPlanoSaudePorIdHandler executed!");
    }
}
