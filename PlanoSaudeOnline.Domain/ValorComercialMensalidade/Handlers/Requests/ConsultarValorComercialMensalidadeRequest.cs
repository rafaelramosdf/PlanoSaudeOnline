using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Requests;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;

public class ConsultarValorComercialMensalidadeRequest : PagedQueryRequestBase
{
    public ConsultarValorComercialMensalidadeRequest()
    {
    }

    public ConsultarValorComercialMensalidadeRequest(string Id)
    {
        this.Id = Id;
    }

    public string? Id { get; set; }
    public List<string> Ids { get; set; } = new List<string>();
    public string? IdPlanoSaude { get; set; }
    public string? CodigoFaixaEtaria { get; set; }

    public Expression<Func<Entities.ValorComercialMensalidade, bool>> ObterConsulta()
    {
        if (!string.IsNullOrEmpty(Id))
            return x => x.Id.Equals(Id);

        if (Ids != null && Ids.Any())
            return x => Ids.Contains(x.Id);

        if (!string.IsNullOrEmpty(IdPlanoSaude) && !string.IsNullOrEmpty(CodigoFaixaEtaria))
            return x => x.IdPlanoSaude.Equals(IdPlanoSaude) && x.CodigoFaixaEtaria != null && x.CodigoFaixaEtaria.Equals(CodigoFaixaEtaria);

        if (!string.IsNullOrEmpty(IdPlanoSaude))
            return x => x.IdPlanoSaude.Equals(IdPlanoSaude);

        if (!string.IsNullOrEmpty(CodigoFaixaEtaria))
            return x => x.CodigoFaixaEtaria != null && x.CodigoFaixaEtaria.Equals(CodigoFaixaEtaria);

        return x => true;
    }
}
