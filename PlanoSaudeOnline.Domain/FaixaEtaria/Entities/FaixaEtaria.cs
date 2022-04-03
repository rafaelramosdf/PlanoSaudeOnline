using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.FaixaEtaria.Entities;

public class FaixaEtaria : EntityBase
{
    public FaixaEtaria(string codigoFaixaEtaria, int idadeMinima, int idadeMaxima, string? descricao)
    {
        CodigoFaixaEtaria = codigoFaixaEtaria;
        IdadeMinima = idadeMinima;
        IdadeMaxima = idadeMaxima;
        Descricao = descricao;
    }

    public string CodigoFaixaEtaria { get; set; }

    public int IdadeMinima { get; set; }

    public int IdadeMaxima { get; set; }

    public string? Descricao { get; set; }
}
