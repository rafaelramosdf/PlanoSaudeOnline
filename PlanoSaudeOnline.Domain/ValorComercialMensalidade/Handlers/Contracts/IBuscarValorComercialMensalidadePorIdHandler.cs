using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Responses;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;

public interface IBuscarValorComercialMensalidadePorIdHandler
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<ValorComercialMensalidadeResponse>, string>
{
}
