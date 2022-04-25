using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Responses;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;

public interface IConsultarValorComercialMensalidadeHandler
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<PagedQueryResponse<IEnumerable<ValorComercialMensalidadeResponse>>>, ConsultarValorComercialMensalidadeRequest>
{
}
