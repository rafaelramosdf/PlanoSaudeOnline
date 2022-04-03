using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.RedeEstabelecimento.Entities;

public class RedeEstabelecimento : EntityBase
{
    public RedeEstabelecimento(string idRede, 
        string idEstabelecimentoSaude, 
        string nomeEstabelecimentoSaude, 
        string? cnpjEstabelecimentoSaude, 
        string? classificacaoEstabelecimentoSaude, 
        bool? possuiAtendimentoUrgenciaEmergencia, 
        string idPlano, 
        bool? codigoPlano, 
        bool? registroAnsOperadora, 
        string? codigoMunicipio, 
        string? nomeMunicipio, 
        string? siglaUf, 
        DateTime? dataInicioVinculo, 
        DateTime? dataFinalVinculo, 
        string? nomeRegiao)
    {
        IdRede = idRede;
        IdEstabelecimentoSaude = idEstabelecimentoSaude;
        NomeEstabelecimentoSaude = nomeEstabelecimentoSaude;
        CnpjEstabelecimentoSaude = cnpjEstabelecimentoSaude;
        ClassificacaoEstabelecimentoSaude = classificacaoEstabelecimentoSaude;
        PossuiAtendimentoUrgenciaEmergencia = possuiAtendimentoUrgenciaEmergencia;
        IdPlano = idPlano;
        CodigoPlano = codigoPlano;
        RegistroAnsOperadora = registroAnsOperadora;
        CodigoMunicipio = codigoMunicipio;
        NomeMunicipio = nomeMunicipio;
        SiglaUf = siglaUf;
        DataInicioVinculo = dataInicioVinculo;
        DataFinalVinculo = dataFinalVinculo;
        NomeRegiao = nomeRegiao;
    }

    public string IdRede { get; set; }

    public string IdEstabelecimentoSaude { get; set; }

    public string NomeEstabelecimentoSaude { get; set; }

    public string? CnpjEstabelecimentoSaude { get; set; }

    public string? ClassificacaoEstabelecimentoSaude { get; set; }

    public bool? PossuiAtendimentoUrgenciaEmergencia { get; set; }

    public string IdPlano { get; set; }

    public bool? CodigoPlano { get; set; }

    public bool? RegistroAnsOperadora { get; set; }

    public string? CodigoMunicipio { get; set; }

    public string? NomeMunicipio { get; set; }

    public string? SiglaUf { get; set; }

    public DateTime? DataInicioVinculo { get; set; }

    public DateTime? DataFinalVinculo { get; set; }

    public string? NomeRegiao { get; set; }
}
