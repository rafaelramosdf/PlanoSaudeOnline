using PlanoSaudeOnline.Domain.RedeEstabelecimento.Entities;
using PlanoSaudeOnline.Domain.RedeEstabelecimento.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class RedeEstabelecimentoRepository : RepositoryBase<RedeEstabelecimento>, IRedeEstabelecimentoRepository
{
    public RedeEstabelecimentoRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("RedeEstabelecimento", settings)
    {

    }
}
