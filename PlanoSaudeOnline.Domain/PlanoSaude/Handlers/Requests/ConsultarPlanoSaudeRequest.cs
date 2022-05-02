using PlanoSaudeOnline.Domain._Shared.Contracts.Handlers.Requests;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;

public class ConsultarPlanoSaudeRequest : IQueryRequest<Entities.PlanoSaude>
{
    public ConsultarPlanoSaudeRequest()
    {
    }

    public ConsultarPlanoSaudeRequest(string Id)
    {
        this.Id = Id;
    }

    public string? Id { get; set; }
    public List<string> Ids { get; set; } = new List<string>();
    public string? Nome { get; set; }
    public string? Codigo { get; set; }
    public string? RegistroAnsOperadora { get; set; }

    public string? Search { get; set; } = string.Empty;
    public int Page { get; set; } = 1;
    public int Limit { get; set; } = 10;

    public Expression<Func<Entities.PlanoSaude, bool>> Query()
    {
        if (!string.IsNullOrEmpty(Id))
            return x => x.Id.Equals(Id);

        if (Ids != null && Ids.Any())
            return x => Ids.Contains(x.Id);

        if (!string.IsNullOrEmpty(Codigo))
            return x => x.CodigoPlano != null && x.CodigoPlano.Equals(Codigo);

        if (!string.IsNullOrEmpty(RegistroAnsOperadora))
            return x => x.RegistroAnsOperadora != null && x.RegistroAnsOperadora.Equals(RegistroAnsOperadora);

        if (!string.IsNullOrEmpty(Nome))
            return x =>
            x.NomePlano.ToLower().Contains(Nome.ToLower()) ||
            x.NomePlano.ToLower().Contains(Nome.ToLower());

        return x => true;
    }
}
