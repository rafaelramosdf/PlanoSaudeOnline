using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Api.Models.Base;

namespace PlanoSaudeOnline.Api.Models
{
    public class FaixaEtaria : EntityBase
    {
        [BsonElement("CodigoFaixaEtaria")]
        public string? CodigoFaixaEtaria { get; set; }

        [BsonElement("IdadeMinima")]
        public int? IdadeMinima { get; set; }

        [BsonElement("IdadeMaxima")]
        public int? IdadeMaxima { get; set; }

        [BsonElement("Descricao")]
        public string? Descricao { get; set; }
    }
}
