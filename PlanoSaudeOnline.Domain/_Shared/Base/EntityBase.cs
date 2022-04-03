using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlanoSaudeOnline.Domain._Shared.Base;

public abstract class EntityBase
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public virtual string? Id { get; set; }
}
