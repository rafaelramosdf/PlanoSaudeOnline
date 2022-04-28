namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;

public class IncluirOperadoraPlanoSaudeRequest
{
    public IncluirOperadoraPlanoSaudeRequest()
    {
    }

    public IncluirOperadoraPlanoSaudeRequest(bool ativo, 
        string registroAns, 
        string cnpj, 
        string razaoSocial, 
        string nomeFantasia, 
        string? modalidade, 
        string? logradouro, 
        string? numero, 
        string? complemento, 
        string? bairro, 
        string? cidade, 
        string? uf, 
        string? cep, 
        string? regiaoComercializacao, 
        DateTime? dataRegistroAns)
    {
        Ativo = ativo;
        RegistroAns = registroAns;
        Cnpj = cnpj;
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        Modalidade = modalidade;
        Logradouro = logradouro;
        Complemento = complemento;
        Bairro = bairro;
        Cidade = cidade;
        Uf = uf;
        Cep = cep;
        RegiaoComercializacao = regiaoComercializacao;
        DataRegistroAns = dataRegistroAns;
    }

    public IncluirOperadoraPlanoSaudeRequest(Entities.OperadoraPlanoSaude operadoraPlanoSaudeRequest)
    {
        Ativo = operadoraPlanoSaudeRequest.Ativo;
        RegistroAns = operadoraPlanoSaudeRequest.RegistroAns;
        Cnpj = operadoraPlanoSaudeRequest.Cnpj;
        RazaoSocial = operadoraPlanoSaudeRequest.RazaoSocial;
        NomeFantasia = operadoraPlanoSaudeRequest.NomeFantasia;
        Modalidade = operadoraPlanoSaudeRequest.Modalidade;
        Logradouro = operadoraPlanoSaudeRequest.Logradouro;
        Complemento = operadoraPlanoSaudeRequest.Complemento;
        Bairro = operadoraPlanoSaudeRequest.Bairro;
        Cidade = operadoraPlanoSaudeRequest.Cidade;
        Uf = operadoraPlanoSaudeRequest.Uf;
        Cep = operadoraPlanoSaudeRequest.Cep;
        RegiaoComercializacao = operadoraPlanoSaudeRequest.RegiaoComercializacao;
        DataRegistroAns = operadoraPlanoSaudeRequest.DataRegistroAns;
    }

    public bool Ativo { get; set; } = true;
    public string RegistroAns { get; set; } = "";
    public string Cnpj { get; set; } = "";
    public string RazaoSocial { get; set; } = "";
    public string NomeFantasia { get; set; }
    public string? Modalidade { get; set; }
    public string? Logradouro { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Cidade { get; set; }
    public string? Uf { get; set; }
    public string? Cep { get; set; }
    public string? RegiaoComercializacao { get; set; }
    public DateTime? DataRegistroAns { get; set; }
}
