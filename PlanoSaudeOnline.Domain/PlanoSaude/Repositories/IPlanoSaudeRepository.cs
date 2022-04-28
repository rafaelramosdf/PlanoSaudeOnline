using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain._Shared.Contracts.Repositories;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Repositories;

public interface IPlanoSaudeRepository : IRepositoryBase<Entities.PlanoSaude>
{
    Task<PagedQueryResponse<IEnumerable<Entities.PlanoSaude>>> BuscarTodos();
}
