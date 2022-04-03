namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;

public class ConsultarOperadoraPlanoSaudeRequest 
{
    public ConsultarOperadoraPlanoSaudeRequest()
    {
    }

    public ConsultarOperadoraPlanoSaudeRequest(string Id)
    {
        this.Id = Id;
    }

    public string? Id { get; set; }
    public IEnumerable<string>? Ids { get; set; }
}
