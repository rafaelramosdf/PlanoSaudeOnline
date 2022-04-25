using PlanoSaudeOnline.Domain._Shared.Base.Entities;

namespace PlanoSaudeOnline.Domain.FaixaEtaria.Entities;

/// <summary>
/// "Faixa etária do beneficiário vinculado ao contrato:
/// (01)  00 (zero) a 18 (dezoito) anos;
/// (02)  19 (dezenove) a 23 (vinte e três) anos;
/// (03)  24 (vinte e quatro) a 28 (vinte e oito) anos;
/// (04)  29 (vinte e nove) a 33 (trinta e três) anos;
/// (05)  34 (trinta e quatro) a 38 (trinta e oito) anos;
/// (06)  39 (trinta e nove) a 43 (quarenta e três) anos;
/// (07)  44 (quarenta e quatro) a 48 (quarenta e oito) anos;
/// (08)  49 (quarenta e nove) a 53 (cinquenta e três) anos;
/// (09)  54 (cinquenta e quatro) a 58 (cinquenta e oito) anos;
/// (10)  59 (cinquenta e nove) anos ou mais.”
/// Nota: As faixas etárias da NTRP seguem o determinado pelo Art. 2º da RN nº 63, de 22 de dezembro de 2003."
/// </summary>
public class FaixaEtaria : Entity
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
