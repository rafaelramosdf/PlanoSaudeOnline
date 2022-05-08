using PlanoSaudeOnline.Domain._Shared.Enumerations;

namespace PlanoSaudeOnline.Domain.Cotacao.Handlers.Responses;

public class RealizarCotacaoResponse
{
    public List<RealizarCotacaoPlanoSaudeResponse> Planos { get; set; } = new List<RealizarCotacaoPlanoSaudeResponse>();
}

public class RealizarCotacaoPlanoSaudeResponse
{
    public string NomeOperadoraPlanoSaude { get; set; }
    public string NomePlanoSaude { get; set; }
    public decimal ValorMensalidade => Vidas.Sum(s => s.ValorMensalidade);

    public List<RealizarCotacaoPlanoSaudeVidaResponse> Vidas { get; set; } = new List<RealizarCotacaoPlanoSaudeVidaResponse>();
}

public class RealizarCotacaoPlanoSaudeVidaResponse
{
    public FaixaEtariaEnum FaixaEtaria { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorMensalidade { get; set; }
}
