using PlanoSaudeOnline.Domain._Shared.Enumerations;

namespace PlanoSaudeOnline.Domain.Cotacao.Handlers.Requests;

public class RealizarCotacaoRequest
{
    public string Uf { get; set; }
    public string Cidade { get; set; }
    public TipoContratacaoEnum TipoContratacao { get; set; }
    public string DescricaoTipoContratacao => TipoContratacao.EnumDescription();
    public SegmentoAssistencialEnum SegmentoAssistencial { get; set; }
    public string DescricaoSegmentoAssistencial => SegmentoAssistencial.EnumDescription();
    public List<RealizarCotacaoVidaRequest> Vidas { get; set; } = new List<RealizarCotacaoVidaRequest>();
}

public class RealizarCotacaoVidaRequest
{
    public FaixaEtariaEnum FaixaEtaria { get; set; }
    public int CodigoFaixaEtaria => FaixaEtaria.GetHashCode();
    public int Quantidade { get; set; }
}
