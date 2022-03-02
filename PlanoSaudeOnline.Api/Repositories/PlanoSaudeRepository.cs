using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Base;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Settings;

namespace PlanoSaudeOnline.Api.Repositories;

public class PlanoSaudeRepository : RepositoryBase<PlanoSaude>, IPlanoSaudeRepository
{
    public PlanoSaudeRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base(settings)
    {

    }
}
