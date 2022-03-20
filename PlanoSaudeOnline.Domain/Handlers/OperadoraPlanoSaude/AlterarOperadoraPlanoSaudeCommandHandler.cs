using MediatR;
using PlanoSaudeOnline.Domain.Contracts.Repositories;

namespace PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

public class AlterarOperadoraPlanoSaudeCommandHandler : AsyncRequestHandler<AlterarOperadoraPlanoSaudeCommand>
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public AlterarOperadoraPlanoSaudeCommandHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    protected override async Task Handle(AlterarOperadoraPlanoSaudeCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Handle AlterarOperadoraPlanoSaudeCommandHandler executed!");
    }
}
