using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Requests;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;

public class ConsultarOperadoraPlanoSaudeRequest : PagedQueryRequestBase
{
    public ConsultarOperadoraPlanoSaudeRequest()
    {
    }

    public ConsultarOperadoraPlanoSaudeRequest(string Id)
    {
        this.Id = Id;
    }

    public string? Id { get; set; }
    public IEnumerable<string>? Ids { get; set; }

    public Expression<Func<Entities.OperadoraPlanoSaude, bool>> ObterConsulta() 
    {
        if (!string.IsNullOrEmpty(Id))
            return x => x.Id.Equals(Id);

        if (Ids?.Any() == true)
            return x => Ids.Contains(x.Id);

        return x => true;
    }
}
