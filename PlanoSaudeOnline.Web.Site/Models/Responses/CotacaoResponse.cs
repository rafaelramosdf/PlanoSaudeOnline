using PlanoSaudeOnline.Web.Site.Models.Enumerations;

namespace PlanoSaudeOnline.Web.Site.Models.Responses;

public class CotacaoResponse
{
    public string NomeOperadoraPlanoSaude { get; set; }
    public string NomePlanoSaude { get; set; }
    public decimal ValorMensalidade => Vidas.Sum(s => s.ValorMensalidade);

    public List<CotacaoVidaResponse> Vidas { get; set; } = new List<CotacaoVidaResponse>();
}

public class CotacaoVidaResponse
{
    public FaixaEtariaEnum FaixaEtaria { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorMensalidade { get; set; }
}