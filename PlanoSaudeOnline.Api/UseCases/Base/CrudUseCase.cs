using PlanoSaudeOnline.Api.Models.Base;
using PlanoSaudeOnline.Api.Repositories.Base;

namespace PlanoSaudeOnline.Api.UseCases.Base;

public class CrudUseCase<TEntity, TRepository> : ICrudUseCase<TEntity>
    where TEntity : EntityBase
    where TRepository : IRepositoryBase<TEntity>
{
    private readonly TRepository Repository;

    public CrudUseCase(TRepository Repository)
    {
        this.Repository = Repository;
    }

    public TEntity Incluir(TEntity entity)
    {
        return Repository.Create(entity);
    }

    public void Alterar(string id, TEntity entity)
    {
        Repository.Update(id, entity);
    }

    public void Excluir(string id)
    {
        Repository.Remove(id);
    }

    public void Excluir(TEntity entity)
    {
        Repository.Remove(entity);
    }

    public TEntity ListarPorId(string id)
    {
        return Repository.Get(id);
    }

    public List<TEntity> Listar(int? page = 1, int? limit = 10)
    {
        return Repository.Get(page, limit);
    }
}
