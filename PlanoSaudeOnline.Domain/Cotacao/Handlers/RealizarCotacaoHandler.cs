using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain._Shared.Enumerations;
using PlanoSaudeOnline.Domain.Cotacao.Handlers.Contracts;
using PlanoSaudeOnline.Domain.Cotacao.Handlers.Requests;
using PlanoSaudeOnline.Domain.Cotacao.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;
using PlanoSaudeOnline.Domain.PlanoSaude.Repositories;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Repositories;

namespace PlanoSaudeOnline.Domain.Cotacao.Handlers;

public class RealizarCotacaoHandler : IRealizarCotacaoHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;
    private readonly IPlanoSaudeRepository planoSaudeRepository;
    private readonly IValorComercialMensalidadeRepository valorComercialMensalidadeRepository;

    public RealizarCotacaoHandler(
        IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository,
        IPlanoSaudeRepository planoSaudeRepository,
        IValorComercialMensalidadeRepository valorComercialMensalidadeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
        this.planoSaudeRepository = planoSaudeRepository;
        this.valorComercialMensalidadeRepository = valorComercialMensalidadeRepository;
    }

    public async Task<HandlerResponse<RealizarCotacaoResponse>> HandleAsync(RealizarCotacaoRequest request)
    {
        var response = new RealizarCotacaoResponse();

        var listaRegiaoComercializacao = ObterListaRegiaoComercializacao(request.Uf, request.Cidade);

        var listaOperadoras = await operadoraPlanoSaudeRepository.Buscar(q =>
            !string.IsNullOrEmpty(q.RegiaoComercializacao) && 
            listaRegiaoComercializacao.Contains(q.RegiaoComercializacao));

        var listaCodigoOperadoras = listaOperadoras.Select(s => s.RegistroAns).ToList();

        var listaPlanoSaude = await planoSaudeRepository.Buscar(q => 
            listaCodigoOperadoras.Contains(q.RegistroAnsOperadora) &&
            q.SituacaoPlano == "Ativo" && 
            q.TipoContratacao == request.DescricaoTipoContratacao && 
            q.SegmentoAssistencial == request.DescricaoSegmentoAssistencial);

        foreach (var plano in listaPlanoSaude)
        {
            var cotacaoPlano = new RealizarCotacaoPlanoSaudeResponse();
            cotacaoPlano.NomePlanoSaude = plano.NomePlano;
            cotacaoPlano.NomeOperadoraPlanoSaude = listaOperadoras.FirstOrDefault(m => m.RegistroAns == plano.RegistroAnsOperadora)?.RazaoSocial ?? "";

            foreach (var vida in request.Vidas.Where(v => v.Quantidade > 0))
            {
                var listaValorComercial = await valorComercialMensalidadeRepository.Buscar(q => 
                    q.IdPlanoSaude == plano.IdPlano &&
                    q.CodigoFaixaEtaria == vida.CodigoFaixaEtaria);

                foreach (var valorComercial in listaValorComercial)
                {
                    cotacaoPlano.Vidas.Add(new RealizarCotacaoPlanoSaudeVidaResponse 
                    {
                        FaixaEtaria = vida.FaixaEtaria,
                        Quantidade = vida.Quantidade,
                        ValorMensalidade = valorComercial.ValorMensalidade
                    });
                }
            }

            response.Planos.Add(cotacaoPlano);
        }

        return new HandlerResponse<RealizarCotacaoResponse>(System.Net.HttpStatusCode.OK, response);
    }

    private List<string> ObterListaRegiaoComercializacao(string uf, string cidade) 
    {
        /// "Área onde a operadora de plano privado de assistência à saúde comercializa ou disponibiliza seu plano de saúde, nos termos do Anexo I da Resolução Normativa nº 209/2009, da ANS.
        /// • Região 1: em todo o território nacional ou em grupos de pelo menos três estados dentre os seguintes: São Paulo, Rio de Janeiro, Minas Gerais, Rio Grande do Sul, Paraná e Bahia;
        /// • Região 2: no Estado de São Paulo ou em mais de um estado, excetuando os grupos definidos no critério da região 1;
        /// • Região 3: em um único estado, qualquer que seja ele, excetuando-se o Estado de São Paulo;
        /// • Região 4: no Município de São Paulo, do Rio de Janeiro, de Belo Horizonte, de Porto Alegre ou de Curitiba ou de Brasília;
        /// • Região 5: em grupo de municípios, excetuando os definidos na região 4;
        /// • Região 6: em um único município, excetuando os definidos na região 4."

        var listaEstadosDaRegiaoUm = EnumerationExtension.EnumDescriptions<UfEnum>();

        var listaEstadosDaRegiaoDois = listaEstadosDaRegiaoUm.Where(m => 
            m != UfEnum.Rj.EnumDescription() && 
            m != UfEnum.Mg.EnumDescription() && 
            m != UfEnum.Rs.EnumDescription() && 
            m != UfEnum.Pr.EnumDescription() && 
            m != UfEnum.Ba.EnumDescription());
        
        var listaEstadosDaRegiaoTres = listaEstadosDaRegiaoUm.Where(m => m != UfEnum.Sp.EnumDescription());

        var listaEstadosDaRegiaoQuatro = listaEstadosDaRegiaoUm.Where(m => 
            m == UfEnum.Sp.EnumDescription() ||
            m == UfEnum.Rj.EnumDescription() ||
            m == UfEnum.Mg.EnumDescription() ||
            m == UfEnum.Rs.EnumDescription() ||
            m == UfEnum.Pr.EnumDescription() ||
            m == UfEnum.Df.EnumDescription());

        var listaCidadesDaRegiaoQuatro = EnumerationExtension.EnumDescriptions<CidadesChaveRegiaoComercializacaoEnum>()
            .Where(m => m != CidadesChaveRegiaoComercializacaoEnum.Indiferente.EnumDescription());

        var listaRegiaoComercializacao = new List<string>();

        if(listaEstadosDaRegiaoUm.Contains(uf))
            listaRegiaoComercializacao.Add("1");

        if (listaEstadosDaRegiaoDois.Contains(uf))
            listaRegiaoComercializacao.Add("2");

        if (listaEstadosDaRegiaoTres.Contains(uf))
            listaRegiaoComercializacao.Add("3");

        if (listaEstadosDaRegiaoQuatro.Contains(uf) && listaCidadesDaRegiaoQuatro.Contains(cidade))
            listaRegiaoComercializacao.Add("4");

        if (listaEstadosDaRegiaoUm.Contains(uf) && !listaCidadesDaRegiaoQuatro.Contains(cidade)) 
            listaRegiaoComercializacao.AddRange(new List<string> { "5", "6" });

        return listaRegiaoComercializacao;
    }
}
