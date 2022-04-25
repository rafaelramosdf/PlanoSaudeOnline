using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Responses;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;

public interface IConsultarPlanoSaudeHandler
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<PagedQueryResponse<IEnumerable<PlanoSaudeResponse>>>, ConsultarPlanoSaudeRequest>
{
}
