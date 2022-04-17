using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;

public interface IIncluirOperadoraPlanoSaudeHandler 
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<OperadoraPlanoSaudeResponse>, IncluirOperadoraPlanoSaudeRequest>
{
}
