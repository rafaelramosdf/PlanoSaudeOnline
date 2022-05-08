using MongoDB.Driver;
using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain._Shared.Contracts.Handlers.Requests;
using PlanoSaudeOnline.Domain._Shared.Contracts.Repositories;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
    where TEntity : Entity
{
    public readonly IMongoCollection<TEntity> EntityMongoCollection;

    public RepositoryBase(string collectionName, IDbPlanoSaudeOnlineConnectionString settings)
    {
        var mongoClientSettings = MongoClientSettings.FromUrl(new MongoUrl(settings.ConnectionString));
        mongoClientSettings.SslSettings.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;

        var client = new MongoClient(mongoClientSettings);
        var database = client.GetDatabase(settings.DatabaseName);

        EntityMongoCollection = database.GetCollection<TEntity>(name: collectionName);
    }

    public virtual TEntity Buscar(string id) =>
        EntityMongoCollection.Find(s => s.Id == id).FirstOrDefault();

    public virtual async Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(IQueryRequest<TEntity> queryRequest)
    {
        var query = queryRequest.Query();
        var currentPage = queryRequest.Page - 1;
        var nextPage = queryRequest.Page;
        var hasNextPage = false;

        queryRequest.Limit = queryRequest.Limit > 1000 ? 1000 : queryRequest.Limit;

        var items = (await EntityMongoCollection.FindAsync(query, 
            new FindOptions<TEntity> 
            { 
                Skip = currentPage, 
                Limit = queryRequest.Limit
            })).ToList();

        hasNextPage = (await EntityMongoCollection.CountDocumentsAsync(query, new CountOptions { Skip = nextPage, Limit = queryRequest.Limit })) > 0;

        return new PagedQueryResponse<IEnumerable<TEntity>>(items, queryRequest.Page, queryRequest.Limit, hasNextPage);
    }

    public virtual async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> query)
    {
        return (await EntityMongoCollection.FindAsync(query)).ToList();
    }

    public virtual TEntity Inserir(TEntity entity)
    {
        entity.CadastradoEm = DateTime.Now;
        EntityMongoCollection.InsertOne(entity);
        return entity;
    }

    public virtual void Inserir(IEnumerable<TEntity> entities)
    {
        EntityMongoCollection.InsertMany(entities);
    }

    public virtual void Alterar(string id, TEntity entityIn)
    {
        entityIn.AlteradoEm = DateTime.Now;
        EntityMongoCollection.ReplaceOne(entity => entity.Id == id, entityIn);
    }

    public virtual void Remover(TEntity entityIn) =>
        EntityMongoCollection.DeleteOne(entity => entity.Id == entityIn.Id);

    public virtual void Remover(string id) =>
        EntityMongoCollection.DeleteOne(entity => entity.Id == id);
}
