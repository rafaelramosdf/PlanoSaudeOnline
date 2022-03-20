using MediatR;
using PlanoSaudeOnline.Domain.Contracts.Repositories;

namespace PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

public class IncluirOperadoraPlanoSaudeCommandHandler : IRequestHandler<IncluirOperadoraPlanoSaudeCommand, OperadoraPlanoSaudeResponse>
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public IncluirOperadoraPlanoSaudeCommandHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<OperadoraPlanoSaudeResponse> Handle(IncluirOperadoraPlanoSaudeCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Handle IncluirOperadoraPlanoSaudeCommandHandler executed!");
        return null;
    }
}
