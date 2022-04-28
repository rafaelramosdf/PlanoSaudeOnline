using MongoDB.Driver;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.PlanoSaude.Entities;
using PlanoSaudeOnline.Domain.PlanoSaude.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;

public class PlanoSaudeRepository : RepositoryBase<PlanoSaude>, IPlanoSaudeRepository
{
    public PlanoSaudeRepository(IDbPlanoSaudeOnlineConnectionString settings)
        : base("PlanoSaude", settings)
    {
    }

    public async Task<PagedQueryResponse<IEnumerable<PlanoSaude>>> BuscarTodos()
    {
        var queryStatement = await EntityMongoCollection.FindAsync(_ => true,
            new FindOptions<PlanoSaude>
            {
                MaxTime = TimeSpan.FromSeconds(20)
            });

        var items = queryStatement.ToList();

        return new PagedQueryResponse<IEnumerable<PlanoSaude>>(items, 1, 1, 1);
    }
}
