﻿using System.ComponentModel;

namespace PlanoSaudeOnline.Web.Site.Models.Enumerations;

public enum TipoContratacaoEnum
{
    [Description("Individual ou familiar")]
    IndividualOuFamiliar,

    [Description("Individual ou Familiar + Coletivo por Adesão")]
    IndividualOuFamiliarMaisColetivoPorAdesao,

    [Description("Individual ou Familiar + Coletivo Empresarial")]
    IndividualOuFamiliarMaisColetivoEmpresarial,

    [Description("Individual + Coletivo Empresarial + Coletivo por Adesão")]
    IndividualMaisColetivoEmpresarialMaisColetivoPorAdesao,

    [Description("Coletivo por adesão")]
    ColetivoPorAdesao,

    [Description("Coletivo empresarial")]
    ColetivoEmpresarial,

    [Description("Coletivo Empresarial + Coletivo por Adesão")]
    ColetivoEmpresarialMaisColetivoPorAdesao
}
