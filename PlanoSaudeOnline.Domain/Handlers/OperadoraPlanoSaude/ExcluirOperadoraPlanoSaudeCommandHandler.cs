using MediatR;
using PlanoSaudeOnline.Domain.Contracts.Repositories;

namespace PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

public class ExcluirOperadoraPlanoSaudeCommandHandler : AsyncRequestHandler<ExcluirOperadoraPlanoSaudeCommand>
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public ExcluirOperadoraPlanoSaudeCommandHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    protected override async Task Handle(ExcluirOperadoraPlanoSaudeCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Handle ExcluirOperadoraPlanoSaudeCommandHandler executed!");
    }
}
