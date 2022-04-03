using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Entities;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class ValorComercialMensalidadeRepository : RepositoryBase<ValorComercialMensalidade>, IValorComercialMensalidadeRepository
{
    public ValorComercialMensalidadeRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("ValorComercialMensalidade", settings)
    {

    }
}
