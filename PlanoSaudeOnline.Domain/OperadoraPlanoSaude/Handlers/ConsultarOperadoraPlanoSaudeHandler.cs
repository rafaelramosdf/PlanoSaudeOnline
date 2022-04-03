using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class ConsultarOperadoraPlanoSaudeHandler : IConsultarOperadoraPlanoSaudeHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public ConsultarOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<IActionResult> HandleAsync(ConsultarOperadoraPlanoSaudeRequest request)
    {
        Console.WriteLine("Handle ConsultarOperadoraPlanoSaudeQuery executed!");
        return new OkObjectResult("Handle ConsultarOperadoraPlanoSaudeQuery executed!");
    }
}
