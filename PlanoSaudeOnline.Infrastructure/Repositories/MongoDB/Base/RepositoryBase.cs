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

    public virtual TEntity Buscar(string id) =>
        EntityMongoCollection.Find(s => s.Id == id).FirstOrDefault();

    public virtual async Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(int page = 1, int perPage = 10)
    {
        perPage = perPage > 1000 ? 1000 : perPage;

        var queryStatement = await EntityMongoCollection.FindAsync(_ => true, 
            new FindOptions<TEntity> 
            { 
                Skip = page - 1, 
                Limit = perPage 
            });

        var totalItems = await EntityMongoCollection.EstimatedDocumentCountAsync(new EstimatedDocumentCountOptions { MaxTime = TimeSpan.FromMilliseconds(1000) });
        var items = queryStatement.ToList();

        return new PagedQueryResponse<IEnumerable<TEntity>>(items, page, perPage, totalItems);
    }

    public virtual async Task<PagedQueryResponse<IEnumerable<TEntity>>> Buscar(Expression<Func<TEntity, bool>> query, int page = 1, int perPage = 10)
    {
        perPage = perPage > 1000 ? 1000 : perPage;

        var queryStatement = await EntityMongoCollection.FindAsync(query, 
            new FindOptions<TEntity> 
            { 
                Skip = page - 1, 
                Limit = perPage 
            });

        var totalItems = await EntityMongoCollection.CountDocumentsAsync(query, new CountOptions { MaxTime = TimeSpan.FromMilliseconds(1000) });
        
        var items = queryStatement.ToList();
        return new PagedQueryResponse<IEnumerable<TEntity>>(items, page, perPage, totalItems);
    }

    public virtual async Task<PagedQueryResponse<IEnumerable<TEntity>>> Pesquisar(string? search, int page = 1, int perPage = 10)
    {
        perPage = perPage > 1000 ? 1000 : perPage;

        FilterDefinition<TEntity>? filter;
        var tags = search?.ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        filter = !string.IsNullOrEmpty(search) 
            ? Builders<TEntity>.Filter.All(c => c.Tags, tags) 
            : Builders<TEntity>.Filter.Where(_ => true);

        var queryStatement = await EntityMongoCollection.FindAsync(filter,
            new FindOptions<TEntity>
            {
                Skip = page - 1,
                Limit = perPage
            });

        var totalItems = await EntityMongoCollection.CountDocumentsAsync(filter);
        var items = queryStatement.ToList();

        return new PagedQueryResponse<IEnumerable<TEntity>>(items, page, perPage, totalItems);
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
