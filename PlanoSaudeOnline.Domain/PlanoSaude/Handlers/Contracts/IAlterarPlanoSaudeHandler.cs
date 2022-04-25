using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;

public interface IAlterarPlanoSaudeHandler
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse, AlterarPlanoSaudeRequest>
{
}
