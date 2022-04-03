using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlanoSaudeOnline.Domain._Shared.Base;

[Serializable]
[BsonIgnoreExtraElements]
public abstract class EntityBase
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public virtual string? Id { get; set; }
    public virtual DateTime CadastradoEm { get; set; } = DateTime.Now;
    public virtual DateTime? AlteradoEm { get; set; }
}
