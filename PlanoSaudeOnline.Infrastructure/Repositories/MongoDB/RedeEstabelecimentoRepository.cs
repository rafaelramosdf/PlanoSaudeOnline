using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Domain.Entities;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class RedeEstabelecimentoRepository : RepositoryBase<RedeEstabelecimento>, IRedeEstabelecimentoRepository
{
    public RedeEstabelecimentoRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("RedeEstabelecimento", settings)
    {

    }
}
