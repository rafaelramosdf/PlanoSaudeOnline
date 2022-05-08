using PlanoSaudeOnline.Domain.Cotacao.Repositories;
using PlanoSaudeOnline.Domain.Cotacao.Entities;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class CotacaoVidaRepository : RepositoryBase<CotacaoVida>, ICotacaoVidaRepository
{
    public CotacaoVidaRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("CotacaoVida", settings)
    {

    }
}
