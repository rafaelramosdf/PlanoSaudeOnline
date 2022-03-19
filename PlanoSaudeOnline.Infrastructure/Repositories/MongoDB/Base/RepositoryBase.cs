using MongoDB.Driver;
using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Domain.Entities.Base;
using System.Linq.Expressions;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
    where TEntity : EntityBase
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

    public virtual List<TEntity> Get(int? page = 1, int? limit = 10) =>
        EntityMongoCollection.Find(entity => true).Skip((page - 1) * limit).Limit(limit).ToList();

    public virtual List<TEntity> Get(Expression<Func<TEntity, bool>> query, int? page = 1, int? limit = 10) =>
        EntityMongoCollection.Find(query).Skip((page - 1) * limit).Limit(limit).ToList();

    public virtual TEntity Get(string id) =>
        EntityMongoCollection.Find(s => s.Id == id).FirstOrDefault();

    public virtual TEntity Create(TEntity entity)
    {
        EntityMongoCollection.InsertOne(entity);
        return entity;
    }

    public virtual void Update(string id, TEntity entityIn) =>
        EntityMongoCollection.ReplaceOne(entity => entity.Id == id, entityIn);

    public virtual void Remove(TEntity entityIn) =>
        EntityMongoCollection.DeleteOne(entity => entity.Id == entityIn.Id);

    public virtual void Remove(string id) =>
        EntityMongoCollection.DeleteOne(entity => entity.Id == id);
}
