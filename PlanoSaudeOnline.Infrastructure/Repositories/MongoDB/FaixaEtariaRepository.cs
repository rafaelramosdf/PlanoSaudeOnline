using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Domain.Entities;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class FaixaEtariaRepository : RepositoryBase<FaixaEtaria>, IFaixaEtariaRepository
{
    public FaixaEtariaRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("FaixaEtaria", settings)
    {

    }
}
