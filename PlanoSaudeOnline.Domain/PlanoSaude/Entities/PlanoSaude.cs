using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Entities;

public class PlanoSaude : Entity
{
    public PlanoSaude(
        string idPlano, 
        string nomePlano, 
        string codigoPlano, 
        string registroAnsOperadora, 
        string? tipoContratacao, 
        string? segmentoAssistencial, 
        string? possuiCoberturaObstetricia, 
        string? possuiCoberturaOdontologica,
        string? cobertura,
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
        PossuiCoberturaOdontologica = possuiCoberturaOdontologica;
        Cobertura = cobertura;
        AbrangenciaCobertura = abrangenciaCobertura;
        AcomodacaoHospitalar = acomodacaoHospitalar;
        FatorModerador = fatorModerador;
        SituacaoPlano = situacaoPlano;
        DataSituacaoPlano = dataSituacaoPlano;
        DataRegistroPlano = dataRegistroPlano;
        DataAtualizacao = dataAtualizacao;
    }

    public PlanoSaude(IncluirPlanoSaudeRequest incluirPlanoSaudeRequest)
    {
        IdPlano = incluirPlanoSaudeRequest.IdPlano;
        NomePlano = incluirPlanoSaudeRequest.NomePlano;
        CodigoPlano = incluirPlanoSaudeRequest.CodigoPlano;
        RegistroAnsOperadora = incluirPlanoSaudeRequest.RegistroAnsOperadora;
        TipoContratacao = incluirPlanoSaudeRequest.TipoContratacao;
        SegmentoAssistencial = incluirPlanoSaudeRequest.SegmentoAssistencial;
        PossuiCoberturaObstetricia = incluirPlanoSaudeRequest.PossuiCoberturaObstetricia;
        PossuiCoberturaOdontologica = incluirPlanoSaudeRequest.PossuiCoberturaOdontologica;
        Cobertura = incluirPlanoSaudeRequest.Cobertura;
        AbrangenciaCobertura = incluirPlanoSaudeRequest.AbrangenciaCobertura;
        AcomodacaoHospitalar = incluirPlanoSaudeRequest.AcomodacaoHospitalar;
        FatorModerador = incluirPlanoSaudeRequest.FatorModerador;
        SituacaoPlano = incluirPlanoSaudeRequest.SituacaoPlano;
        DataSituacaoPlano = incluirPlanoSaudeRequest.DataSituacaoPlano;
        DataRegistroPlano = incluirPlanoSaudeRequest.DataRegistroPlano;
        DataAtualizacao = incluirPlanoSaudeRequest.DataAtualizacao;
    }

    public PlanoSaude(AlterarPlanoSaudeRequest alterarPlanoSaudeRequest)
    {
        Id = alterarPlanoSaudeRequest.Id;
        IdPlano = alterarPlanoSaudeRequest.IdPlano;
        NomePlano = alterarPlanoSaudeRequest.NomePlano;
        CodigoPlano = alterarPlanoSaudeRequest.CodigoPlano;
        RegistroAnsOperadora = alterarPlanoSaudeRequest.RegistroAnsOperadora;
        TipoContratacao = alterarPlanoSaudeRequest.TipoContratacao;
        SegmentoAssistencial = alterarPlanoSaudeRequest.SegmentoAssistencial;
        PossuiCoberturaObstetricia = alterarPlanoSaudeRequest.PossuiCoberturaObstetricia;
        PossuiCoberturaOdontologica = alterarPlanoSaudeRequest.PossuiCoberturaOdontologica;
        Cobertura = alterarPlanoSaudeRequest.Cobertura;
        AbrangenciaCobertura = alterarPlanoSaudeRequest.AbrangenciaCobertura;
        AcomodacaoHospitalar = alterarPlanoSaudeRequest.AcomodacaoHospitalar;
        FatorModerador = alterarPlanoSaudeRequest.FatorModerador;
        SituacaoPlano = alterarPlanoSaudeRequest.SituacaoPlano;
        DataSituacaoPlano = alterarPlanoSaudeRequest.DataSituacaoPlano;
        DataRegistroPlano = alterarPlanoSaudeRequest.DataRegistroPlano;
        DataAtualizacao = alterarPlanoSaudeRequest.DataAtualizacao;
    }

    /// <summary>
    /// Este campo representa o Id do Plano na base da ANS
    /// </summary>
    public string IdPlano { get; set; }

    public string NomePlano { get; set; }

    public string CodigoPlano { get; set; }

    public string RegistroAnsOperadora { get; set; }

    /// <summary>
    /// "Tipo de contratação do plano:
    /// Individual ou familiar
    /// Coletivo empresarial
    /// Coletivo por adesão
    /// Individual ou Familiar + Coletivo Empresarial
    /// Individual ou Familiar + Coletivo por Adesão
    /// Coletivo Empresarial + Coletivo por Adesão
    /// Individual + Coletivo Empresarial + Coletivo por Adesão"
    /// </summary>
    public string? TipoContratacao { get; set; }

    /// <summary>
    /// "Código de segmentação assistencial do plano.
    /// Ambulatorial
    /// Hospitalar com obstetrícia
    /// Hospitalar sem obstetrícia
    /// Odontológico
    /// Referência
    /// Ambulatorial + Hospitalar com obstetrícia
    /// Ambulatorial + Hospitalar sem obstetrícia
    /// Ambulatorial + Odontológico
    /// Hosp c/ obstetrícia + Hosp s/ obstetrícia
    /// Hospitalar com obstetrícia + Odontológico
    /// Hospitalar sem obstetrícia + Odontológico
    /// Amb + Hosp c/s Obstetrícia
    /// Ambulatorial + Hospitalar com obstetrícia + Odontológico
    /// Ambulatorial + Hospitalar sem obstetrícia + Odontológico
    /// Hosp c/s Obstetrícia + Odont "
    /// </summary>
    public string? SegmentoAssistencial { get; set; }

    /// <summary>
    /// "Categorias de cobertura de produto por tipo de segmentação assistencial:
    /// Médico-hospitalar(cobertura médico-hospitalar, pode incluir cobertura odontológica)
    /// Odontológico(exclusivamente odontológico)"
    /// </summary>
    public string? Cobertura { get; set; }

    /// <summary>
    /// "Atributo indicador de cobertura de obstetrícia:
    /// Com obstetrícia
    /// Sem obstetrícia
    /// Não identificado
    /// Não se aplica"
    /// </summary>
    public string? PossuiCoberturaObstetricia { get; set; }

    /// <summary>
    /// "Indicador de plano que inclui cobertura odontológica:
    /// 0 = Não inclui cobertura odontológica
    /// 1 = Inclui cobertura odontológica"
    /// </summary>
    public string? PossuiCoberturaOdontologica { get; set; }

    /// <summary>
    /// "Código das categorias de área de cobertura do plano.
    /// Nacional
    /// Grupo de estados
    /// Estadual
    /// Grupo de municípios
    /// Municipal
    /// Outras"
    /// </summary>
    public string? AbrangenciaCobertura { get; set; }

    /// <summary>
    /// "Tipo de acomodação do plano que oferece internação hospitalar:
    /// Coletiva
    /// Individual
    /// Não se aplica(planos ambulatoriais ou odontológicos)
    /// Não identificado(planos com internação e sem tipo de acomodação informada)"
    /// </summary>
    public string? AcomodacaoHospitalar { get; set; }

    /// <summary>
    /// "Tipo de fator moderador (mecanismo de regulação de utilização) do plano:
    /// Coparticipação
    /// Franquia
    /// Franquia + Coparticipação
    /// Ausente"
    /// </summary>
    public string? FatorModerador { get; set; }

    /// <summary>
    /// "Situação principal do plano:
    /// Ativo
    /// Suspenso
    /// Cancelado
    /// Transferido"
    /// </summary>
    public string? SituacaoPlano { get; set; }

    public DateTime? DataSituacaoPlano { get; set; }

    public DateTime? DataRegistroPlano { get; set; }

    public DateTime? DataAtualizacao { get; set; }
}
