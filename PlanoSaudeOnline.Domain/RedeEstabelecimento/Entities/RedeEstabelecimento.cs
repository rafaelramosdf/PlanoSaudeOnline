using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.RedeEstabelecimento.Entities;

public class RedeEstabelecimento : EntityBase
{
    [BsonElement("IdRede")]
    public string? IdRede { get; set; }

    [BsonElement("IdEstabelecimentoSaude")]
    public string? IdEstabelecimentoSaude { get; set; }

    [BsonElement("CnpjEstabelecimentoSaude")]
    public string? CnpjEstabelecimentoSaude { get; set; }

    [BsonElement("NomeEstabelecimentoSaude")]
    public string? NomeEstabelecimentoSaude { get; set; }

    [BsonElement("ClassificacaoEstabelecimentoSaude")]
    public string? ClassificacaoEstabelecimentoSaude { get; set; }

    [BsonElement("PossuiAtendimentoUrgenciaEmergencia")]
    public bool? PossuiAtendimentoUrgenciaEmergencia { get; set; }

    [BsonElement("IdPlano")]
    public string? IdPlano { get; set; }

    [BsonElement("CodigoPlano")]
    public bool? CodigoPlano { get; set; }

    [BsonElement("RegistroAnsOperadora")]
    public bool? RegistroAnsOperadora { get; set; }

    [BsonElement("CodigoMunicipio")]
    public string? CodigoMunicipio { get; set; }

    [BsonElement("NomeMunicipio")]
    public string? NomeMunicipio { get; set; }

    [BsonElement("SiglaUf")]
    public string? SiglaUf { get; set; }

    [BsonElement("DataInicioVinculo")]
    public DateTime? DataInicioVinculo { get; set; }

    [BsonElement("DataFinalVinculo")]
    public DateTime? DataFinalVinculo { get; set; }

    [BsonElement("NomeRegiao")]
    public string? NomeRegiao { get; set; }
}
