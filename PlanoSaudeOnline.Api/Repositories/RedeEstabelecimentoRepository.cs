using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Base;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Settings;

namespace PlanoSaudeOnline.Api.Repositories;

public class RedeEstabelecimentoRepository : RepositoryBase<RedeEstabelecimento>, IRedeEstabelecimentoRepository
{
    public RedeEstabelecimentoRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base(settings)
    {

    }
}
