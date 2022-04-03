using PlanoSaudeOnline.Domain._Shared.Base;

namespace PlanoSaudeOnline.Domain.Usuario.Entities;

public class Usuario : EntityBase
{
    public Usuario(string nome, 
        string? telefone, 
        string? email, 
        string? tipoPessoa, 
        DateTime? dataUltimaCotacao)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
        TipoPessoa = tipoPessoa;
        DataUltimaCotacao = dataUltimaCotacao;
    }

    public string Nome { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public string? TipoPessoa { get; set; }

    public DateTime? DataUltimaCotacao { get; set; }
}
