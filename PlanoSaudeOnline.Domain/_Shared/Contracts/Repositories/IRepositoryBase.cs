using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Domain._Shared.Contracts.Repositories;

public interface IRepositoryBase<TEntity>
    where TEntity : Entity
{
    Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(int? page, int? perPage);
    Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(Expression<Func<TEntity, bool>> query, int? page = 1, int? perPage = 10);
    TEntity Buscar(string id);
    TEntity Inserir(TEntity entity);
    void Inserir(IEnumerable<TEntity> entities);
    void Alterar(string id, TEntity entity);
    void Remover(TEntity entity);
    void Remover(string id);
}
