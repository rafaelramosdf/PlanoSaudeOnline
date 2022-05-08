using System.ComponentModel;

namespace PlanoSaudeOnline.Domain._Shared.Enumerations;

public enum CidadesChaveRegiaoComercializacaoEnum
{
    [Description("Indiferente")]
    Indiferente,

    [Description("São Paulo")]
    SaoPaulo,

    [Description("Rio de Janeiro")]
    RioDeJaneiro,

    [Description("Belo Horizonte")]
    BeloHorizonte,

    [Description("Porto Alegre")]
    PortoAlegre,

    [Description("Curitiba")]
    Curitiba,

    [Description("Brasília")]
    Brasilia
}
