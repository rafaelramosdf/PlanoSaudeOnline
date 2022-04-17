using PlanoSaudeOnline.Domain._Shared.Base.Entities;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities.Validations;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;

public class OperadoraPlanoSaude : Entity<OperadoraPlanoSaudeValidation>
{
    public OperadoraPlanoSaude(
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

    public OperadoraPlanoSaude(IncluirOperadoraPlanoSaudeRequest incluirOperadoraPlanoSaudeRequest)
    {
        Ativo = incluirOperadoraPlanoSaudeRequest.Ativo;
        RegistroAns = incluirOperadoraPlanoSaudeRequest.RegistroAns;
        Cnpj = incluirOperadoraPlanoSaudeRequest.Cnpj;
        RazaoSocial = incluirOperadoraPlanoSaudeRequest.RazaoSocial;
        NomeFantasia = incluirOperadoraPlanoSaudeRequest.NomeFantasia;
        Modalidade = incluirOperadoraPlanoSaudeRequest.Modalidade;
        Logradouro = incluirOperadoraPlanoSaudeRequest.Logradouro;
        Numero = incluirOperadoraPlanoSaudeRequest.Numero;
        Complemento = incluirOperadoraPlanoSaudeRequest.Complemento;
        Bairro = incluirOperadoraPlanoSaudeRequest.Bairro;
        Cidade = incluirOperadoraPlanoSaudeRequest.Cidade;
        Uf = incluirOperadoraPlanoSaudeRequest.Uf;
        Cep = incluirOperadoraPlanoSaudeRequest.Cep;
        RegiaoComercializacao = incluirOperadoraPlanoSaudeRequest.RegiaoComercializacao;
        DataRegistroAns = incluirOperadoraPlanoSaudeRequest.DataRegistroAns;
    }

    public OperadoraPlanoSaude(AlterarOperadoraPlanoSaudeRequest alterarOperadoraPlanoSaudeRequest)
    {
        Id = alterarOperadoraPlanoSaudeRequest.Id;
        Ativo = alterarOperadoraPlanoSaudeRequest.Ativo;
        RegistroAns = alterarOperadoraPlanoSaudeRequest.RegistroAns;
        Cnpj = alterarOperadoraPlanoSaudeRequest.Cnpj;
        RazaoSocial = alterarOperadoraPlanoSaudeRequest.RazaoSocial;
        NomeFantasia = alterarOperadoraPlanoSaudeRequest.NomeFantasia;
        Modalidade = alterarOperadoraPlanoSaudeRequest.Modalidade;
        Logradouro = alterarOperadoraPlanoSaudeRequest.Logradouro;
        Numero = alterarOperadoraPlanoSaudeRequest.Numero;
        Complemento = alterarOperadoraPlanoSaudeRequest.Complemento;
        Bairro = alterarOperadoraPlanoSaudeRequest.Bairro;
        Cidade = alterarOperadoraPlanoSaudeRequest.Cidade;
        Uf = alterarOperadoraPlanoSaudeRequest.Uf;
        Cep = alterarOperadoraPlanoSaudeRequest.Cep;
        RegiaoComercializacao = alterarOperadoraPlanoSaudeRequest.RegiaoComercializacao;
        DataRegistroAns = alterarOperadoraPlanoSaudeRequest.DataRegistroAns;
    }

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
