using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.Usuario.Entities;

public class Usuario : EntityBase
{
    [BsonElement("Nome")]
    public string? Nome { get; set; }

    [BsonElement("Telefone")]
    public string? Telefone { get; set; }

    [BsonElement("Email")]
    public string? Email { get; set; }

    [BsonElement("TipoPessoa")]
    public string? TipoPessoa { get; set; }

    [BsonElement("DataCadastro")]
    public DateTime? DataCadastro { get; set; }

    [BsonElement("DataUltimaCotacao")]
    public DateTime? DataUltimaCotacao { get; set; }
}
