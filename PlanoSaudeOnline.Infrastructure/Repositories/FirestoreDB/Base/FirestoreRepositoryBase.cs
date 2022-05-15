using Google.Cloud.Firestore;
using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain._Shared.Contracts.Repositories.FirestoreDB;

namespace PlanoSaudeOnline.Infrastructure.Repositories.FirestoreDB.Base;

public class FirestoreRepositoryBase<TEntity> : IFirestoreRepositoryBase<TEntity>
    where TEntity : FirestoreEntity
{
    private readonly CollectionReference FirestoreCollection = null!;

    public FirestoreRepositoryBase(FirestoreDb firestoreDb)
    {
        FirestoreCollection = firestoreDb.Collection(typeof(TEntity).Name);
    }

    public virtual async Task<TEntity> Buscar(string id) 
    {
        var document = FirestoreCollection.Document(id);
        var snapshot = await document.GetSnapshotAsync();
        return snapshot.ConvertTo<TEntity>();
    }

    public virtual async Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(Func<TEntity, bool> query, int page, int limit)
    {
        var currentPage = page - 1;
        var nextPage = page;
        var hasNextPage = false;
        limit = limit > 1000 ? 1000 : limit;

        var items = (await FirestoreCollection.StartAt(currentPage).Limit(limit).GetSnapshotAsync()).Documents
            .Select(x => x.ConvertTo<TEntity>())
            .Where(query)
            .ToList();

        hasNextPage = (await FirestoreCollection.StartAt(nextPage).Limit(limit).GetSnapshotAsync()).Documents
            .Select(x => x.ConvertTo<TEntity>())
            .Count(query) > 0;

        return new PagedQueryResponse<IEnumerable<TEntity>>(items, page, limit, hasNextPage);
    }

    public virtual async Task<IEnumerable<TEntity>> Buscar(Func<TEntity, bool> query)
    {
        return (await FirestoreCollection.GetSnapshotAsync()).Documents
            .Select(x => x.ConvertTo<TEntity>())
            .Where(query)
            .ToList();
    }

    public virtual async Task InserirOuAlterar(TEntity entity)
    {
        var document = FirestoreCollection.Document(entity.Id);
        await document.SetAsync(entity);
    }

    public virtual async Task InserirOuAlterar(IEnumerable<TEntity> entities)
    {
        foreach (var entity in entities)
        {
            await InserirOuAlterar(entity);
        }
    }

    public virtual async Task Remover(TEntity entityIn) =>
        await FirestoreCollection.Document(entityIn.Id).DeleteAsync();

    public virtual Task Remover(string id) =>
        FirestoreCollection.Document(id).DeleteAsync();
}
