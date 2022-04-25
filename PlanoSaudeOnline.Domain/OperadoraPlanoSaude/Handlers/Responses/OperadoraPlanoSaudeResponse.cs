namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;

public class OperadoraPlanoSaudeResponse
{
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

    /// <summary>
    /// "Área onde a operadora de plano privado de assistência à saúde comercializa ou disponibiliza seu plano de saúde, nos termos do Anexo I da Resolução Normativa nº 209/2009, da ANS.
    /// • Região 1: em todo o território nacional ou em grupos de pelo menos três estados dentre os seguintes: São Paulo, Rio de Janeiro, Minas Gerais, Rio Grande do Sul, Paraná e Bahia;
    /// • Região 2: no Estado de São Paulo ou em mais de um estado, excetuando os grupos definidos no critério da região 1;
    /// • Região 3: em um único estado, qualquer que seja ele, excetuando-se o Estado de São Paulo;
    /// • Região 4: no Município de São Paulo, do Rio de Janeiro, de Belo Horizonte, de Porto Alegre ou de Curitiba ou de Brasília;
    /// • Região 5: em grupo de municípios, excetuando os definidos na região 4; e
    /// • Região 6: em um único município, excetuando os definidos na região 4."
    /// </summary>
    public string? RegiaoComercializacao { get; set; }
    public DateTime? DataRegistroAns { get; set; }
}