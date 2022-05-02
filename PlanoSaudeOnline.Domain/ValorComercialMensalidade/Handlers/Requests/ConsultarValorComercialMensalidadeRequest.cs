using PlanoSaudeOnline.Domain._Shared.Contracts.Handlers.Requests;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;

public class ConsultarValorComercialMensalidadeRequest : IQueryRequest<Entities.ValorComercialMensalidade>
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
    public int? CodigoFaixaEtaria { get; set; }

    public string? Search { get; set; } = string.Empty;
    public int Page { get; set; } = 1;
    public int Limit { get; set; } = 10;

    public Expression<Func<Entities.ValorComercialMensalidade, bool>> Query()
    {
        if (!string.IsNullOrEmpty(Id))
            return x => x.Id.Equals(Id);

        if (Ids != null && Ids.Any())
            return x => Ids.Contains(x.Id);

        if (!string.IsNullOrEmpty(IdPlanoSaude) && CodigoFaixaEtaria > 0)
            return x => x.IdPlanoSaude.Equals(IdPlanoSaude) && x.CodigoFaixaEtaria > 0 && x.CodigoFaixaEtaria.Equals(CodigoFaixaEtaria);

        if (!string.IsNullOrEmpty(IdPlanoSaude))
            return x => x.IdPlanoSaude.Equals(IdPlanoSaude);

        if (CodigoFaixaEtaria > 0)
            return x => x.CodigoFaixaEtaria > 0 && x.CodigoFaixaEtaria.Equals(CodigoFaixaEtaria);

        return x => true;
    }
}
