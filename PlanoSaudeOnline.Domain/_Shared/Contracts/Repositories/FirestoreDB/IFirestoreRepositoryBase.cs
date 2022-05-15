using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;

namespace PlanoSaudeOnline.Domain._Shared.Contracts.Repositories.FirestoreDB;

public interface IFirestoreRepositoryBase<TEntity>
    where TEntity : FirestoreEntity
{
    Task<TEntity> Buscar(string id);
    Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(Func<TEntity, bool> query, int page, int limit);
    Task<IEnumerable<TEntity>> Buscar(Func<TEntity, bool> query);
    Task InserirOuAlterar(TEntity entity);
    Task InserirOuAlterar(IEnumerable<TEntity> entities);
    Task Remover(TEntity entity);
    Task Remover(string id);
}
