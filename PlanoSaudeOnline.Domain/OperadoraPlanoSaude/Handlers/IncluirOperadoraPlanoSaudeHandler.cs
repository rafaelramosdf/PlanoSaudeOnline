using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class IncluirOperadoraPlanoSaudeHandler : IIncluirOperadoraPlanoSaudeHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public IncluirOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<IActionResult> HandleAsync(IncluirOperadoraPlanoSaudeRequest request)
    {
        var operadoraPlanoSaude = new Entities.OperadoraPlanoSaude(request);

        if (!operadoraPlanoSaude.IsValid)
            return new BadRequestObjectResult(operadoraPlanoSaude.Notifications);

        operadoraPlanoSaude = operadoraPlanoSaudeRepository.Create(operadoraPlanoSaude);

        return new CreatedAtRouteResult(
            nameof(operadoraPlanoSaude), 
            new { id = operadoraPlanoSaude.Id }, 
            operadoraPlanoSaude);
    }
}
