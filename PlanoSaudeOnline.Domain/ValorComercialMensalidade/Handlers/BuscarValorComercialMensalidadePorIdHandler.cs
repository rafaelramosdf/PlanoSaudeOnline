using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Responses;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Repositories;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers;

public class BuscarValorComercialMensalidadePorIdHandler : IBuscarValorComercialMensalidadePorIdHandler
{
    private readonly IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository;

    public BuscarValorComercialMensalidadePorIdHandler(IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository)
    {
        this.ValorComercialMensalidadeRepository = ValorComercialMensalidadeRepository;
    }

    public async Task<HandlerResponse<ValorComercialMensalidadeResponse>> HandleAsync(string request)
    {
        return await Task.Run(() =>
        {
            var ValorComercialMensalidade = ValorComercialMensalidadeRepository.Buscar(request);

            Console.WriteLine("Handle BuscarValorComercialMensalidadePorIdHandler executed!");

            if (ValorComercialMensalidade == null)
                return new HandlerResponse<ValorComercialMensalidadeResponse>(System.Net.HttpStatusCode.NotFound);

            return new HandlerResponse<ValorComercialMensalidadeResponse>(
                System.Net.HttpStatusCode.OK,
                new ValorComercialMensalidadeResponse(ValorComercialMensalidade));
        });
    }
}
