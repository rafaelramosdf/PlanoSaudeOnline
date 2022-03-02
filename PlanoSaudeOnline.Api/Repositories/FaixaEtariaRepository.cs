using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Base;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Settings;

namespace PlanoSaudeOnline.Api.Repositories;

public class FaixaEtariaRepository : RepositoryBase<FaixaEtaria>, IFaixaEtariaRepository
{
    public FaixaEtariaRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base(settings)
    {

    }
}
