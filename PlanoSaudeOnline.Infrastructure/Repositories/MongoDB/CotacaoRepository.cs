using PlanoSaudeOnline.Domain.Cotacao.Entities;
using PlanoSaudeOnline.Domain.Cotacao.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class CotacaoRepository : RepositoryBase<Cotacao>, ICotacaoRepository
{
    public CotacaoRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("Cotacao", settings)
    {

    }
}
