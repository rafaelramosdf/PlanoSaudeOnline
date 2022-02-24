using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Api.Models.Base;

namespace PlanoSaudeOnline.Api.Models
{
    public class ValorComercialMensalidade : EntityBase
    {
        [BsonElement("IdFaixaEtaria")]
        public string? IdFaixaEtaria { get; set; }

        [BsonElement("CodigoFaixaEtaria")]
        public string? CodigoFaixaEtaria { get; set; }

        [BsonElement("IdPlanoSaude")]
        public string? IdPlanoSaude { get; set; }

        [BsonElement("ValorMensalidade")]
        public decimal? ValorMensalidade { get; set; }

        [BsonElement("DataHoraAtualizacao")]
        public DateTime? DataHoraAtualizacao { get; set; }
    }
}
