using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;

public interface IAlterarValorComercialMensalidadeHandler
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse, AlterarValorComercialMensalidadeRequest>
{
}
