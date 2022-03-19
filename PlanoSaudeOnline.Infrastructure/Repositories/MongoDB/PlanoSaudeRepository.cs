using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Domain.Entities;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class PlanoSaudeRepository : RepositoryBase<PlanoSaude>, IPlanoSaudeRepository
{
    public PlanoSaudeRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("PlanoSaude", settings)
    {

    }
}
