using PlanoSaudeOnline.Domain.Entities.Base;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Domain.Contracts.Repositories;

public interface IRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    List<TEntity> Get(int? page, int? limit);
    List<TEntity> Get(Expression<Func<TEntity, bool>> query, int? page = 1, int? limit = 10);
    TEntity Get(string id);
    TEntity Create(TEntity entity);
    void Update(string id, TEntity entity);
    void Remove(TEntity entity);
    void Remove(string id);
}
