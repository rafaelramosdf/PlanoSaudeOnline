using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;

public interface IAlterarOperadoraPlanoSaudeHandler 
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse, AlterarOperadoraPlanoSaudeRequest>
{
}
