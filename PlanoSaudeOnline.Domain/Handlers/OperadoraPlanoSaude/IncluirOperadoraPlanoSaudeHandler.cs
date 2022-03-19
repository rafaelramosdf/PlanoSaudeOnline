using MediatR;
using PlanoSaudeOnline.Domain.Contracts.Repositories;

namespace PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

public class IncluirOperadoraPlanoSaudeHandler : IRequestHandler<IncluirOperadoraPlanoSaudeRequest, IncluirOperadoraPlanoSaudeResponse>
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public IncluirOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public Task<IncluirOperadoraPlanoSaudeResponse> Handle(IncluirOperadoraPlanoSaudeRequest request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Handle executing...");
        return null;
    }
}
