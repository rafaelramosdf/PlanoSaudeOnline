using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class ExcluirOperadoraPlanoSaudeHandler : IExcluirOperadoraPlanoSaudeHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public ExcluirOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<IActionResult> HandleAsync(string request)
    {
        Console.WriteLine("Handle ExcluirOperadoraPlanoSaudeCommandHandler executed!");
        return new NoContentResult();
    }
}
