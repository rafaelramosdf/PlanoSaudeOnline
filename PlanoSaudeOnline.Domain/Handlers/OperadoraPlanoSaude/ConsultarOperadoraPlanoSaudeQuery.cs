using MediatR;

namespace PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

public class ConsultarOperadoraPlanoSaudeQuery : QueryBase, IRequest<IEnumerable<OperadoraPlanoSaudeResponse>>
{
    public ConsultarOperadoraPlanoSaudeQuery()
    {
    }

    public ConsultarOperadoraPlanoSaudeQuery(string Id)
    {
        this.Id = Id;
    }

    public string? Id { get; set; }
    public IEnumerable<string>? Ids { get; set; }
}
