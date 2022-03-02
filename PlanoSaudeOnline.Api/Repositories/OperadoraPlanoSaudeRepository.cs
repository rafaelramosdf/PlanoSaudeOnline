using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Base;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Settings;

namespace PlanoSaudeOnline.Api.Repositories;

public class OperadoraPlanoSaudeRepository : RepositoryBase<OperadoraPlanoSaude>, IOperadoraPlanoSaudeRepository
{
    public OperadoraPlanoSaudeRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("OperadoraPlanoSaude", settings)
    {

    }
}
