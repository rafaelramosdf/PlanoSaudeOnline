using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Domain.Entities;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("Usuario", settings)
    {

    }
}
