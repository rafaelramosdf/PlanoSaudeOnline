using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Domain._Shared.Contracts.Repositories;

public interface IRepositoryBase<TEntity>
    where TEntity : Entity
{
    TEntity Buscar(string id);
    Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(int page = 1, int perPage = 10);
    Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(Expression<Func<TEntity, bool>> query, int page = 1, int perPage = 10);
    Task<PagedQueryResponse<IEnumerable<TEntity>>> Pesquisar(string? search, int page = 1, int perPage = 10);
    TEntity Inserir(TEntity entity);
    void Inserir(IEnumerable<TEntity> entities);
    void Alterar(string id, TEntity entity);
    void Remover(TEntity entity);
    void Remover(string id);
}
