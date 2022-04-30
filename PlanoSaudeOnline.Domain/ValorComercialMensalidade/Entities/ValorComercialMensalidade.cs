using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain._Shared.Enumerations;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Entities;

public class ValorComercialMensalidade : Entity
{
    public ValorComercialMensalidade( 
        int codigoFaixaEtaria, 
        string idPlanoSaude, 
        decimal valorMensalidade, 
        DateTime? dataAtualizacao)
    {
        CodigoFaixaEtaria = codigoFaixaEtaria;
        IdPlanoSaude = idPlanoSaude;
        ValorMensalidade = valorMensalidade;
        DataAtualizacao = dataAtualizacao;
        InicializarTags();
    }

    public ValorComercialMensalidade(IncluirValorComercialMensalidadeRequest incluirValorComercialMensalidadeRequest)
    {
        CodigoFaixaEtaria = incluirValorComercialMensalidadeRequest.CodigoFaixaEtaria;
        IdPlanoSaude = incluirValorComercialMensalidadeRequest.IdPlanoSaude;
        ValorMensalidade = incluirValorComercialMensalidadeRequest.ValorMensalidade;
        DataAtualizacao = incluirValorComercialMensalidadeRequest.DataAtualizacao;
        InicializarTags();
    }

    public ValorComercialMensalidade(AlterarValorComercialMensalidadeRequest alterarValorComercialMensalidadeRequest)
    {
        Id = alterarValorComercialMensalidadeRequest.Id;
        CodigoFaixaEtaria = alterarValorComercialMensalidadeRequest.CodigoFaixaEtaria;
        IdPlanoSaude = alterarValorComercialMensalidadeRequest.IdPlanoSaude;
        ValorMensalidade = alterarValorComercialMensalidadeRequest.ValorMensalidade;
        DataAtualizacao = alterarValorComercialMensalidadeRequest.DataAtualizacao;
        InicializarTags();
    }

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
    public int CodigoFaixaEtaria { get; set; }

    public string IdPlanoSaude { get; set; }

    public decimal ValorMensalidade { get; set; }

    public DateTime? DataAtualizacao { get; set; }

    private void InicializarTags()
    {
        AddTag(IdPlanoSaude);
        AddTag(CodigoFaixaEtaria.ToString());
    }
}
