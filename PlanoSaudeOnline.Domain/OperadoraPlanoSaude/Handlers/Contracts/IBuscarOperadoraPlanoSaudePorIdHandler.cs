using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;

public interface IBuscarOperadoraPlanoSaudePorIdHandler 
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<OperadoraPlanoSaudeResponse>, string>
{
}
