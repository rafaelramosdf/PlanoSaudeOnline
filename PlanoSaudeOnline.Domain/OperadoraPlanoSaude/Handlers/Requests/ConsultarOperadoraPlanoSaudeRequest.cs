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
    public List<string> Ids { get; set; } = new List<string>();
    public string? Nome { get; set; }
    public string? Cnpj { get; set; }
    public string? Uf { get; set; }

    public Expression<Func<Entities.OperadoraPlanoSaude, bool>> ObterConsulta() 
    {
        if (!string.IsNullOrEmpty(Id))
            return x => x.Id.Equals(Id);

        if (Ids != null && Ids.Any())
            return x => Ids.Contains(x.Id);

        if (!string.IsNullOrEmpty(Cnpj))
            return x => x.Cnpj.Equals(Cnpj);

        if(!string.IsNullOrEmpty(Uf) && !string.IsNullOrEmpty(Nome))
            return x => 
            x.Uf != null && x.Uf.ToLower() == Uf.ToLower() && 
            (x.RazaoSocial.ToLower().Contains(Nome.ToLower()) || 
            x.NomeFantasia.ToLower().Contains(Nome.ToLower()));

        if (!string.IsNullOrEmpty(Nome))
            return x => 
            x.RazaoSocial.ToLower().Contains(Nome.ToLower()) || 
            x.NomeFantasia.ToLower().Contains(Nome.ToLower());

        if (!string.IsNullOrEmpty(Uf))
            return x =>
            x.Uf != null && x.Uf.ToLower() == Uf.ToLower();

        return x => true;
    }
}
