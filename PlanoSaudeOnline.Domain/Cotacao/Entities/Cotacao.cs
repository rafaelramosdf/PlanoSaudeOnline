using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.Cotacao.Entities;

public class Cotacao : EntityBase
{
    public Cotacao(string idCliente, string idPlanoSaude, decimal valorMensalidadeCotacao, DateTime dataHora)
    {
        IdCliente = idCliente;
        IdPlanoSaude = idPlanoSaude;
        ValorMensalidadeCotacao = valorMensalidadeCotacao;
        DataHora = dataHora;
    }

    public string IdCliente { get; set; }

    public string IdPlanoSaude { get; set; }

    public decimal ValorMensalidadeCotacao { get; set; }

    public DateTime DataHora { get; set; }
}
