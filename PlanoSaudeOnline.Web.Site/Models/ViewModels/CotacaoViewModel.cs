using PlanoSaudeOnline.Web.Site.Models.Enumerations;

namespace PlanoSaudeOnline.Web.Site.Models.ViewModels;

public class CotacaoViewModel
{
    public string Uf { get; set; }
    public TipoContratacaoEnum TipoContratacao { get; set; }
    public SegmentoAssistencialEnum SegmentoAssistencial { get; set; }
    public List<CotacaoVidaViewModel> Vidas { get; set; } = new List<CotacaoVidaViewModel>();
}
