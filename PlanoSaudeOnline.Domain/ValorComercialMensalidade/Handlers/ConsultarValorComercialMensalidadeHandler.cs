using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Responses;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Repositories;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers;

public class ConsultarValorComercialMensalidadeHandler : IConsultarValorComercialMensalidadeHandler
{
    private readonly IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository;

    public ConsultarValorComercialMensalidadeHandler(IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository)
    {
        this.ValorComercialMensalidadeRepository = ValorComercialMensalidadeRepository;
    }

    public async Task<HandlerResponse<PagedQueryResponse<IEnumerable<ValorComercialMensalidadeResponse>>>> HandleAsync(ConsultarValorComercialMensalidadeRequest request)
    {
        var queryResult = await ValorComercialMensalidadeRepository.Buscar(request.ObterConsulta(), request.Page, request.Limit);

        Console.WriteLine("Handle ConsultarValorComercialMensalidadeHandler executed!");

        if (queryResult.Items == null || !queryResult.Items.Any())
            return new HandlerResponse<PagedQueryResponse<IEnumerable<ValorComercialMensalidadeResponse>>>(System.Net.HttpStatusCode.NoContent);

        return new HandlerResponse<PagedQueryResponse<IEnumerable<ValorComercialMensalidadeResponse>>>(System.Net.HttpStatusCode.OK, queryResult.ConverterParaValorComercialMensalidadeResponse());
    }
}
