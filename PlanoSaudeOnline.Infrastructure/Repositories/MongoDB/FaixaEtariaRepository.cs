using PlanoSaudeOnline.Domain.FaixaEtaria.Entities;
using PlanoSaudeOnline.Domain.FaixaEtaria.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class FaixaEtariaRepository : RepositoryBase<FaixaEtaria>, IFaixaEtariaRepository
{
    public FaixaEtariaRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("FaixaEtaria", settings)
    {

    }
}
