﻿using PlanoSaudeOnline.Domain._Shared.Base.Entities;
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
        InicializarTags();
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
        Complemento = incluirOperadoraPlanoSaudeRequest.Complemento;
        Bairro = incluirOperadoraPlanoSaudeRequest.Bairro;
        Cidade = incluirOperadoraPlanoSaudeRequest.Cidade;
        Uf = incluirOperadoraPlanoSaudeRequest.Uf;
        Cep = incluirOperadoraPlanoSaudeRequest.Cep;
        RegiaoComercializacao = incluirOperadoraPlanoSaudeRequest.RegiaoComercializacao;
        DataRegistroAns = incluirOperadoraPlanoSaudeRequest.DataRegistroAns;
        InicializarTags();
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
        Complemento = alterarOperadoraPlanoSaudeRequest.Complemento;
        Bairro = alterarOperadoraPlanoSaudeRequest.Bairro;
        Cidade = alterarOperadoraPlanoSaudeRequest.Cidade;
        Uf = alterarOperadoraPlanoSaudeRequest.Uf;
        Cep = alterarOperadoraPlanoSaudeRequest.Cep;
        RegiaoComercializacao = alterarOperadoraPlanoSaudeRequest.RegiaoComercializacao;
        DataRegistroAns = alterarOperadoraPlanoSaudeRequest.DataRegistroAns;
        InicializarTags();
    }

    public bool Ativo { get; set; }

    public string RegistroAns { get; set; }

    public string Cnpj { get; set; }

    public string RazaoSocial { get; set; }

    public string NomeFantasia { get; set; }

    public string? Modalidade { get; set; }

    public string? Logradouro { get; set; }

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

    public void InicializarTags()
    {
        var tags = new List<string>();

        tags.Add(RegistroAns);
        tags.Add(Cnpj);
        tags.Add(RazaoSocial);
        tags.Add(NomeFantasia);

        if(!string.IsNullOrEmpty(Modalidade))
            tags.Add(Modalidade);

        if (!string.IsNullOrEmpty(Cidade))
            tags.Add(Cidade);

        if (!string.IsNullOrEmpty(Uf))
            tags.Add(Uf);

        SetTags(tags);
    }
}
