using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Responses;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;

public interface IIncluirPlanoSaudeHandler
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<PlanoSaudeResponse>, IncluirPlanoSaudeRequest>
{
}
