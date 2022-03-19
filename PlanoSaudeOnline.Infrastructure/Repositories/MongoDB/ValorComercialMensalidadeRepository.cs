using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Domain.Entities;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class ValorComercialMensalidadeRepository : RepositoryBase<ValorComercialMensalidade>, IValorComercialMensalidadeRepository
{
    public ValorComercialMensalidadeRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("ValorComercialMensalidade", settings)
    {

    }
}
