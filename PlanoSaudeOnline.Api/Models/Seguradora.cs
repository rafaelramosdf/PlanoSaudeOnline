using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlanoSaudeOnline.Api.Models
{
    public class Seguradora
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Nome")]
        public string? Nome { get; set; }

        [BsonElement("UrlLogo")]
        public string? UrlLogo { get; set; }
    }
}
