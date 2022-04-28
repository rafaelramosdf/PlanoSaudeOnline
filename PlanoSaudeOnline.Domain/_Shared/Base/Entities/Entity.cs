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
    public string Id { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime CadastradoEm { get; set; } = DateTime.Now;

    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime? AlteradoEm { get; set; }

    public List<string> Tags { get; private set; } = new List<string>();

    protected void SetTags(List<string> tags)
    {
        foreach (var t in tags)
        {
            if (!string.IsNullOrEmpty(t))
            {
                Tags.AddRange(t.ToLower().Split(" ").ToList());
            }
        }
    }

    protected void AddTag(string? tag)
    {
        if (!string.IsNullOrEmpty(tag))
            Tags.Add(tag.ToLower());
    }

    protected void AddTag(List<string> tags)
    {
        if (tags.Any())
        {
            foreach (var t in tags)
            {
                AddTag(t.ToLower());
            }
        }
    }
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
