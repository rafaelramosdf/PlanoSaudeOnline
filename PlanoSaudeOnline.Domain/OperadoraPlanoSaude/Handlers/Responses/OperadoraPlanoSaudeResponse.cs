namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;

public class OperadoraPlanoSaudeResponse
{
    public OperadoraPlanoSaudeResponse()
    {
    }

    public OperadoraPlanoSaudeResponse(string id, 
        bool ativo, 
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
        Id = id;
        Ativo = ativo;
        RegistroAns = registroAns;
        Cnpj = cnpj;
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        Modalidade = modalidade;
        Logradouro = logradouro;
        Numero = numero;
        Complemento = complemento;
        Bairro = bairro;
        Cidade = cidade;
        Uf = uf;
        Cep = cep;
        RegiaoComercializacao = regiaoComercializacao;
        DataRegistroAns = dataRegistroAns;
    }

    public OperadoraPlanoSaudeResponse(Entities.OperadoraPlanoSaude operadoraPlanoSaude)
    {
        Id = operadoraPlanoSaude.Id;
        Ativo = operadoraPlanoSaude.Ativo;
        RegistroAns = operadoraPlanoSaude.RegistroAns;
        Cnpj = operadoraPlanoSaude.Cnpj;
        RazaoSocial = operadoraPlanoSaude.RazaoSocial;
        NomeFantasia = operadoraPlanoSaude.NomeFantasia;
        Modalidade = operadoraPlanoSaude.Modalidade;
        Logradouro = operadoraPlanoSaude.Logradouro;
        Numero = operadoraPlanoSaude.Numero;
        Complemento = operadoraPlanoSaude.Complemento;
        Bairro = operadoraPlanoSaude.Bairro;
        Cidade = operadoraPlanoSaude.Cidade;
        Uf = operadoraPlanoSaude.Uf;
        Cep = operadoraPlanoSaude.Cep;
        RegiaoComercializacao = operadoraPlanoSaude.RegiaoComercializacao;
        DataRegistroAns = operadoraPlanoSaude.DataRegistroAns;
    }

    public string Id { get; set; }
    public bool Ativo { get; set; }
    public string RegistroAns { get; set; }
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public string? Modalidade { get; set; }
    public string? Logradouro { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Cidade { get; set; }
    public string? Uf { get; set; }
    public string? Cep { get; set; }
    public string? RegiaoComercializacao { get; set; }
    public DateTime? DataRegistroAns { get; set; }
}
