using Google.Cloud.Firestore;
using PlanoSaudeOnline.Domain._Shared.Base.Entities;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;

public class OperadoraPlanoSaudeFirestoreEntity : FirestoreEntity
{
    public OperadoraPlanoSaudeFirestoreEntity(OperadoraPlanoSaude operadoraPlanoSaude)
    {
        Id = operadoraPlanoSaude.Id;
        RegistroAns = operadoraPlanoSaude.RegistroAns;
        Cnpj = operadoraPlanoSaude.Cnpj;
        RazaoSocial = operadoraPlanoSaude.RazaoSocial;
        NomeFantasia = operadoraPlanoSaude.NomeFantasia;
        Modalidade = operadoraPlanoSaude.Modalidade;
        Logradouro = operadoraPlanoSaude.Logradouro;
        Complemento = operadoraPlanoSaude.Complemento;
        Bairro = operadoraPlanoSaude.Bairro;
        Cidade = operadoraPlanoSaude.Cidade;
        Uf = operadoraPlanoSaude.Uf;
        Cep = operadoraPlanoSaude.Cep;
        RegiaoComercializacao = operadoraPlanoSaude.RegiaoComercializacao;
        DataRegistroAns = operadoraPlanoSaude.DataRegistroAns;
    }

    [FirestoreProperty]
    public string RegistroAns { get; set; }

    [FirestoreProperty]
    public string Cnpj { get; set; }

    [FirestoreProperty]
    public string RazaoSocial { get; set; }

    [FirestoreProperty]
    public string NomeFantasia { get; set; }

    [FirestoreProperty]
    public string? Modalidade { get; set; }

    [FirestoreProperty]
    public string? Logradouro { get; set; }

    [FirestoreProperty]
    public string? Complemento { get; set; }

    [FirestoreProperty]
    public string? Bairro { get; set; }

    [FirestoreProperty]
    public string? Cidade { get; set; }

    [FirestoreProperty]
    public string? Uf { get; set; }

    [FirestoreProperty]
    public string? Cep { get; set; }

    /// <summary>
    /// "Área onde a operadora de plano privado de assistência à saúde comercializa ou disponibiliza seu plano de saúde, nos termos do Anexo I da Resolução Normativa nº 209/2009, da ANS.
    /// • Região 1: em todo o território nacional ou em grupos de pelo menos três estados dentre os seguintes: São Paulo, Rio de Janeiro, Minas Gerais, Rio Grande do Sul, Paraná e Bahia;
    /// • Região 2: no Estado de São Paulo ou em mais de um estado, excetuando os grupos definidos no critério da região 1;
    /// • Região 3: em um único estado, qualquer que seja ele, excetuando-se o Estado de São Paulo;
    /// • Região 4: no Município de São Paulo, do Rio de Janeiro, de Belo Horizonte, de Porto Alegre ou de Curitiba ou de Brasília;
    /// • Região 5: em grupo de municípios, excetuando os definidos na região 4; 
    /// • Região 6: em um único município, excetuando os definidos na região 4."
    /// </summary>
    [FirestoreProperty]
    public string? RegiaoComercializacao { get; set; }

    [FirestoreProperty]
    public DateTime? DataRegistroAns { get; set; }
}
