using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Domain.Entities;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class CotacaoVidaRepository : RepositoryBase<CotacaoVida>, ICotacaoVidaRepository
{
    public CotacaoVidaRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("CotacaoVida", settings)
    {

    }
}
