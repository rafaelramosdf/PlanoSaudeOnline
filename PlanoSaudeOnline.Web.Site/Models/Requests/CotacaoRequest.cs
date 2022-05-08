using PlanoSaudeOnline.Web.Site.Models.Enumerations;

namespace PlanoSaudeOnline.Web.Site.Models.Requests;

public class CotacaoRequest
{
    public string Uf { get; set; }
    public TipoContratacaoEnum TipoContratacao { get; set; }
    public SegmentoAssistencialEnum SegmentoAssistencial { get; set; }
    public List<CotacaoVidaRequest> Vidas { get; set; } = new List<CotacaoVidaRequest>();
}

public class CotacaoVidaRequest
{
    public FaixaEtariaEnum FaixaEtaria { get; set; }
    public int Quantidade { get; set; }
}