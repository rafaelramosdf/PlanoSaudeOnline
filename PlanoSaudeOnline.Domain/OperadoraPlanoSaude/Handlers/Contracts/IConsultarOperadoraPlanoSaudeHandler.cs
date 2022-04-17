using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;

public interface IConsultarOperadoraPlanoSaudeHandler 
    : _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<PagedQueryResponse<IEnumerable<Entities.OperadoraPlanoSaude>>>, ConsultarOperadoraPlanoSaudeRequest>
{
}
