using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Domain.Entities;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class CotacaoRepository : RepositoryBase<Cotacao>, ICotacaoRepository
{
    public CotacaoRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("Cotacao", settings)
    {

    }
}
