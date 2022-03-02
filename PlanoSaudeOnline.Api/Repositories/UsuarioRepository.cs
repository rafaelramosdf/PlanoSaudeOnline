using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Base;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Settings;

namespace PlanoSaudeOnline.Api.Repositories;

public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("Usuario", settings)
    {

    }
}
