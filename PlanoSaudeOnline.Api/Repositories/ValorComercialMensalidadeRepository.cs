using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Base;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Settings;

namespace PlanoSaudeOnline.Api.Repositories;

public class ValorComercialMensalidadeRepository : RepositoryBase<ValorComercialMensalidade>, IValorComercialMensalidadeRepository
{
    public ValorComercialMensalidadeRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("ValorComercialMensalidade", settings)
    {

    }
}
