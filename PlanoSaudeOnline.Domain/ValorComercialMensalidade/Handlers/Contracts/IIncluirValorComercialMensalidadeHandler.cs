using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Responses;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;

public interface IIncluirValorComercialMensalidadeHandler
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<ValorComercialMensalidadeResponse>, IncluirValorComercialMensalidadeRequest>
{
}
