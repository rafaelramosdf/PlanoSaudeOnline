namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;

public class IncluirPlanoSaudeRequest
{
    public IncluirPlanoSaudeRequest()
    {
    }

    public IncluirPlanoSaudeRequest(
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

    public IncluirPlanoSaudeRequest(Entities.PlanoSaude planoSaude)
    {
        IdPlano = planoSaude.IdPlano;
        NomePlano = planoSaude.NomePlano;
        CodigoPlano = planoSaude.CodigoPlano;
        RegistroAnsOperadora = planoSaude.RegistroAnsOperadora;
        TipoContratacao = planoSaude.TipoContratacao;
        SegmentoAssistencial = planoSaude.SegmentoAssistencial;
        PossuiCoberturaObstetricia = planoSaude.PossuiCoberturaObstetricia;
        PossuiCoberturaOdontologica = planoSaude.PossuiCoberturaOdontologica;
        Cobertura = planoSaude.Cobertura;
        AbrangenciaCobertura = planoSaude.AbrangenciaCobertura;
        AcomodacaoHospitalar = planoSaude.AcomodacaoHospitalar;
        FatorModerador = planoSaude.FatorModerador;
        SituacaoPlano = planoSaude.SituacaoPlano;
        DataSituacaoPlano = planoSaude.DataSituacaoPlano;
        DataRegistroPlano = planoSaude.DataRegistroPlano;
        DataAtualizacao = planoSaude.DataAtualizacao;
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
