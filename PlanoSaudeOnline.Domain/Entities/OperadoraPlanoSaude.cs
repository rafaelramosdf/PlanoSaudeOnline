using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Domain.Entities.Base;

namespace PlanoSaudeOnline.Domain.Entities;

public class OperadoraPlanoSaude : EntityBase
{
    [BsonElement("Ativo")]
    public bool? Ativo { get; set; }

    [BsonElement("RegistroAns")]
    public string? RegistroAns { get; set; }

    [BsonElement("Cnpj")]
    public string? Cnpj { get; set; }

    [BsonElement("RazaoSocial")]
    public string? RazaoSocial { get; set; }

    [BsonElement("NomeFantasia")]
    public string? NomeFantasia { get; set; }

    [BsonElement("Modalidade")]
    public string? Modalidade { get; set; }

    [BsonElement("Logradouro")]
    public string? Logradouro { get; set; }

    [BsonElement("Numero")]
    public string? Numero { get; set; }

    [BsonElement("Complemento")]
    public string? Complemento { get; set; }

    [BsonElement("Bairro")]
    public string? Bairro { get; set; }

    [BsonElement("Cidade")]
    public string? Cidade { get; set; }

    [BsonElement("Uf")]
    public string? Uf { get; set; }

    [BsonElement("Cep")]
    public string? Cep { get; set; }

    [BsonElement("RegiaoComercializacao")]
    public string? RegiaoComercializacao { get; set; }

    [BsonElement("DataRegistroAns")]
    public DateTime? DataRegistroAns { get; set; }
}
