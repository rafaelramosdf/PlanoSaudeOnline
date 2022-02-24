﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Api.Models.Base;

namespace PlanoSaudeOnline.Api.Models
{
    public class PlanoSaude : EntityBase
    {
        [BsonElement("IdPlano")]
        public string? IdPlano { get; set; }

        [BsonElement("CodigoPlano")]
        public string? CodigoPlano { get; set; }

        [BsonElement("NomePlano")]
        public string? NomePlano { get; set; }

        [BsonElement("RegistroAnsOperadora")]
        public string? RegistroAnsOperadora { get; set; }

        [BsonElement("TipoContratacao")]
        public string? TipoContratacao { get; set; }

        [BsonElement("SegmentoAssistencial")]
        public string? SegmentoAssistencial { get; set; }

        [BsonElement("PossuiCoberturaObstetricia")]
        public bool? PossuiCoberturaObstetricia { get; set; }

        [BsonElement("PossuiCoberturaOdontologico")]
        public bool? PossuiCoberturaOdontologico { get; set; }

        [BsonElement("SomenteOdentologico")]
        public bool? SomenteOdentologico { get; set; }

        [BsonElement("AbrangenciaCobertura")]
        public string? AbrangenciaCobertura { get; set; }

        [BsonElement("AcomodacaoHospitalar")]
        public string? AcomodacaoHospitalar { get; set; }

        [BsonElement("FatorModerador")]
        public string? FatorModerador { get; set; }

        [BsonElement("SituacaoPlano")]
        public string? SituacaoPlano { get; set; }

        [BsonElement("DataSituacaoPlano")]
        public string? DataSituacaoPlano { get; set; }

        [BsonElement("DataRegistroPlano")]
        public string? DataRegistroPlano { get; set; }

        [BsonElement("DataAtualizacao")]
        public string? DataAtualizacao { get; set; }
    }
}