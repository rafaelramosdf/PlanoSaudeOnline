using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class OperadoraPlanoSaudeRepository : RepositoryBase<OperadoraPlanoSaude>, IOperadoraPlanoSaudeRepository
{
    public OperadoraPlanoSaudeRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("OperadoraPlanoSaude", settings)
    {

    }
}
