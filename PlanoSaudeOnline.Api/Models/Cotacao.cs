using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Api.Models.Base;

namespace PlanoSaudeOnline.Api.Models
{
    public class Cotacao : EntityBase
    {
        [BsonElement("IdCliente")]
        public string? IdCliente { get; set; }

        [BsonElement("IdPlanoSaude")]
        public string? IdPlanoSaude { get; set; }

        [BsonElement("ValorMensalidadeCotacao")]
        public decimal? ValorMensalidadeCotacao { get; set; }

        [BsonElement("DataHora")]
        public DateTime? DataHora { get; set; }
    }
}
