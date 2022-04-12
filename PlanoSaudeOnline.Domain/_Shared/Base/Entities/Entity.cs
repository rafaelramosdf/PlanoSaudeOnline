using Flunt.Notifications;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlanoSaudeOnline.Domain._Shared.Base.Entities;

[Serializable]
[BsonIgnoreExtraElements]
public abstract class Entity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public virtual string Id { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public virtual DateTime CadastradoEm { get; set; } = DateTime.Now;

    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public virtual DateTime? AlteradoEm { get; set; }
}

[Serializable]
[BsonIgnoreExtraElements]
public abstract class Entity<TValidation> : Entity
    where TValidation : Notifiable<Notification>
{
    [BsonIgnore]
    private TValidation Validator => (TValidation)Activator.CreateInstance(typeof(TValidation), this);

    [BsonIgnore]
    public IEnumerable<Notification> Notifications => Validator.Notifications;

    [BsonIgnore]
    public bool IsValid => Validator.IsValid;
}
