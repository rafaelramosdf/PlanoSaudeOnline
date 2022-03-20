using MediatR;

namespace PlanoSaudeOnline.Domain.Handlers.OperadoraPlanoSaude;

public class IncluirOperadoraPlanoSaudeCommand : IRequest<OperadoraPlanoSaudeResponse>
{
    public bool? Ativo { get; set; }
    public string? RegistroAns { get; set; }
    public string? Cnpj { get; set; }
    public string? RazaoSocial { get; set; }
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
