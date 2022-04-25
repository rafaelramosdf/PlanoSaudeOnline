using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Responses;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Repositories;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers;

public class IncluirValorComercialMensalidadeHandler : IIncluirValorComercialMensalidadeHandler
{
    private readonly IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository;

    public IncluirValorComercialMensalidadeHandler(IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository)
    {
        this.ValorComercialMensalidadeRepository = ValorComercialMensalidadeRepository;
    }

    public async Task<HandlerResponse<ValorComercialMensalidadeResponse>> HandleAsync(IncluirValorComercialMensalidadeRequest request)
    {
        return await Task.Run<HandlerResponse<ValorComercialMensalidadeResponse>>(() =>
        {
            var ValorComercialMensalidade = new Entities.ValorComercialMensalidade(request);

            ValorComercialMensalidade = ValorComercialMensalidadeRepository.Inserir(ValorComercialMensalidade);

            Console.WriteLine("Handle IncluirValorComercialMensalidadeHandler executed!");

            return new HandlerResponse<ValorComercialMensalidadeResponse>(System.Net.HttpStatusCode.Created, new ValorComercialMensalidadeResponse(ValorComercialMensalidade));
        });
    }
}
