using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Domain.Entities;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class OperadoraPlanoSaudeRepository : RepositoryBase<OperadoraPlanoSaude>, IOperadoraPlanoSaudeRepository
{
    public OperadoraPlanoSaudeRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("OperadoraPlanoSaude", settings)
    {

    }
}
