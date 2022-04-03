using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class AlterarOperadoraPlanoSaudeHandler : IAlterarOperadoraPlanoSaudeHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public AlterarOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<IActionResult> HandleAsync(AlterarOperadoraPlanoSaudeRequest request)
    {
        Console.WriteLine("Handle AlterarOperadoraPlanoSaudeCommandHandler executed!");
        return new NoContentResult();
    }
}
