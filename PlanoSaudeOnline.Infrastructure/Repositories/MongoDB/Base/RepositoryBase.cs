using MongoDB.Driver;
using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
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

    public virtual async Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(int? page = 1, int? perPage = 10)
    {
        perPage = perPage > 1000 ? 1000 : perPage;
        var queryStatement = EntityMongoCollection.Find(m => true).Skip((page - 1) * perPage).Limit(perPage).ToListAsync();
        var totalItemsStatement = EntityMongoCollection.Find(m => true).CountDocumentsAsync();

        await Task.WhenAll(queryStatement, totalItemsStatement);

        var items = queryStatement.Result;
        var totalItems = totalItemsStatement.Result;
        return new PagedQueryResponse<IEnumerable<TEntity>>(items, page ?? 1, perPage ?? 10, totalItems);
    }

    public virtual async Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(Expression<Func<TEntity, bool>> query, int? page = 1, int? perPage = 10)
    {
        perPage = perPage > 1000 ? 1000 : perPage;

        var queryStatement = EntityMongoCollection.Find(query).Skip((page - 1) * perPage).Limit(perPage).ToListAsync();
        var totalItemsStatement = EntityMongoCollection.Find(query).CountDocumentsAsync();

        await Task.WhenAll(queryStatement, totalItemsStatement);

        var items = queryStatement.Result;
        var totalItems = totalItemsStatement.Result;
        return new PagedQueryResponse<IEnumerable<TEntity>>(items, page ?? 1, perPage ?? 10, totalItems);
    }

    public virtual TEntity Buscar(string id) =>
        EntityMongoCollection.Find(s => s.Id == id).FirstOrDefault();

    public virtual TEntity Criar(TEntity entity)
    {
        EntityMongoCollection.InsertOne(entity);
        return entity;
    }

    public virtual void Alterar(string id, TEntity entityIn) =>
        EntityMongoCollection.ReplaceOne(entity => entity.Id == id, entityIn);

    public virtual void Remover(TEntity entityIn) =>
        EntityMongoCollection.DeleteOne(entity => entity.Id == entityIn.Id);

    public virtual void Remover(string id) =>
        EntityMongoCollection.DeleteOne(entity => entity.Id == id);
}
