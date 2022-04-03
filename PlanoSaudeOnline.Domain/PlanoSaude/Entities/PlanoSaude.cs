using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Entities;

public class PlanoSaude : EntityBase
{
    public PlanoSaude(string idPlano, 
        string nomePlano, 
        string? codigoPlano, 
        string? registroAnsOperadora, 
        string? tipoContratacao, 
        string? segmentoAssistencial, 
        bool? possuiCoberturaObstetricia, 
        bool? possuiCoberturaOdontologico, 
        bool? somenteOdentologico, 
        string? abrangenciaCobertura, 
        string? acomodacaoHospitalar, 
        string? fatorModerador, 
        string? situacaoPlano, 
        DateTime? dataSituacaoPlano, 
        DateTime? dataRegistroPlano, 
        DateTime? dataAtualizacao)
    {
        IdPlano = idPlano;
        NomePlano = nomePlano;
        CodigoPlano = codigoPlano;
        RegistroAnsOperadora = registroAnsOperadora;
        TipoContratacao = tipoContratacao;
        SegmentoAssistencial = segmentoAssistencial;
        PossuiCoberturaObstetricia = possuiCoberturaObstetricia;
        PossuiCoberturaOdontologico = possuiCoberturaOdontologico;
        SomenteOdentologico = somenteOdentologico;
        AbrangenciaCobertura = abrangenciaCobertura;
        AcomodacaoHospitalar = acomodacaoHospitalar;
        FatorModerador = fatorModerador;
        SituacaoPlano = situacaoPlano;
        DataSituacaoPlano = dataSituacaoPlano;
        DataRegistroPlano = dataRegistroPlano;
        DataAtualizacao = dataAtualizacao;
    }

    public string IdPlano { get; set; }

    public string NomePlano { get; set; }

    public string? CodigoPlano { get; set; }

    public string? RegistroAnsOperadora { get; set; }

    public string? TipoContratacao { get; set; }

    public string? SegmentoAssistencial { get; set; }

    public bool? PossuiCoberturaObstetricia { get; set; }

    public bool? PossuiCoberturaOdontologico { get; set; }

    public bool? SomenteOdentologico { get; set; }

    public string? AbrangenciaCobertura { get; set; }

    public string? AcomodacaoHospitalar { get; set; }

    public string? FatorModerador { get; set; }

    public string? SituacaoPlano { get; set; }

    public DateTime? DataSituacaoPlano { get; set; }

    public DateTime? DataRegistroPlano { get; set; }

    public DateTime? DataAtualizacao { get; set; }
}
