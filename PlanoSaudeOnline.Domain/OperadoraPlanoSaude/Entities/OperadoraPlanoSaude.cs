using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;

public class OperadoraPlanoSaude : EntityBase
{
    public OperadoraPlanoSaude(bool ativo, 
        string registroAns, 
        string cnpj, 
        string razaoSocial, 
        string? nomeFantasia, 
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

    public bool Ativo { get; set; }

    public string RegistroAns { get; set; }

    public string Cnpj { get; set; }

    public string RazaoSocial { get; set; }

    public string? NomeFantasia { get; set; }

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
