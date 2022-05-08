using MongoDB.Bson.Serialization.Attributes;
using PlanoSaudeOnline.Domain._Shared.Base.Entities;

namespace PlanoSaudeOnline.Domain.Cotacao.Entities;

public class CotacaoVida : Entity
{
    public CotacaoVida(string idCotacao, string idFaixaEtaria, int quantidade, decimal valorVida)
    {
        IdCotacao = idCotacao;
        IdFaixaEtaria = idFaixaEtaria;
        Quantidade = quantidade;
        ValorVida = valorVida;
    }

    public string IdCotacao { get; set; }

    public string IdFaixaEtaria { get; set; }

    public int Quantidade { get; set; }

    public decimal ValorVida { get; set; }

    [BsonIgnore]
    public decimal ValorTotal => Quantidade * ValorVida;
}
