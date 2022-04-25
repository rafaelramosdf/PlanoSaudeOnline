using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Responses;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;

public interface IBuscarPlanoSaudePorIdHandler
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<PlanoSaudeResponse>, string>
{
}
