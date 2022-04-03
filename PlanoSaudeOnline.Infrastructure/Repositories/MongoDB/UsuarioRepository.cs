using PlanoSaudeOnline.Domain.Usuario.Entities;
using PlanoSaudeOnline.Domain.Usuario.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("Usuario", settings)
    {

    }
}
