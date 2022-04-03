﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Entities;

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

    [BsonElement("DataAtualizacao")]
    public DateTime? DataAtualizacao { get; set; }
}