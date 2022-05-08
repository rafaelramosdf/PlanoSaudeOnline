using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.Cotacao.Handlers.Requests;
using PlanoSaudeOnline.Domain.Cotacao.Handlers.Responses;

namespace PlanoSaudeOnline.Domain.Cotacao.Handlers.Contracts;

public interface IRealizarCotacaoHandler
: _Shared.Contracts.Handlers.IHandlerAsync<HandlerResponse<RealizarCotacaoResponse>, RealizarCotacaoRequest>
{
}
