using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Base;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Settings;

namespace PlanoSaudeOnline.Api.Repositories;

public class CotacaoRepository : RepositoryBase<Cotacao>, ICotacaoRepository
{
    public CotacaoRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base(settings)
    {

    }
}
