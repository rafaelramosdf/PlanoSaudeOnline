using MediatR;

namespace PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

public class ExcluirOperadoraPlanoSaudeCommand : IRequest
{
    public string? Id { get; set; }
}
