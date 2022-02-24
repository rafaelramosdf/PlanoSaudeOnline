using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Api.Models.Base;

namespace PlanoSaudeOnline.Api.Models
{
    public class OperadoraPlanoSaude : EntityBase
    {
        [BsonElement("Nome")]
        public string? Nome { get; set; }

        [BsonElement("UrlLogo")]
        public string? UrlLogo { get; set; }
    }
}
