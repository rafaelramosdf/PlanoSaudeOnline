using MediatR;
using PlanoSaudeOnline.Domain.Contracts.Repositories;

namespace PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

public class ConsultarOperadoraPlanoSaudeQueryHandler : IRequestHandler<ConsultarOperadoraPlanoSaudeQuery, IEnumerable<OperadoraPlanoSaudeResponse>>
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public ConsultarOperadoraPlanoSaudeQueryHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<IEnumerable<OperadoraPlanoSaudeResponse>> Handle(ConsultarOperadoraPlanoSaudeQuery request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Handle ConsultarOperadoraPlanoSaudeQuery executed!");
        return null;
    }
}
