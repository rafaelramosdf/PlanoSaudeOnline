using PlanoSaudeOnline.Domain._Shared.Base.Entities;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Entities;

public class ValorComercialMensalidade : Entity
{
    public ValorComercialMensalidade(string idFaixaEtaria, 
        string? codigoFaixaEtaria, 
        string idPlanoSaude, 
        decimal? valorMensalidade, 
        DateTime? dataAtualizacao)
    {
        IdFaixaEtaria = idFaixaEtaria;
        CodigoFaixaEtaria = codigoFaixaEtaria;
        IdPlanoSaude = idPlanoSaude;
        ValorMensalidade = valorMensalidade;
        DataAtualizacao = dataAtualizacao;
    }

    public string IdFaixaEtaria { get; set; }

    public string? CodigoFaixaEtaria { get; set; }

    public string IdPlanoSaude { get; set; }

    public decimal? ValorMensalidade { get; set; }

    public DateTime? DataAtualizacao { get; set; }
}
