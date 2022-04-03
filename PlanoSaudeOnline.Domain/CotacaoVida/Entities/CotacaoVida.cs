using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.CotacaoVida.Entities;

public class CotacaoVida : EntityBase
{
    [BsonElement("IdCotacao")]
    public string? IdCotacao { get; set; }

    [BsonElement("IdFaixaEtaria")]
    public string? IdFaixaEtaria { get; set; }

    [BsonElement("Quantidade")]
    public int? Quantidade { get; set; }

    [BsonElement("ValorVida")]
    public decimal? ValorVida { get; set; }

    [BsonElement("ValorTotal")]
    public decimal? ValorTotal => Quantidade * ValorVida;
}
