using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Responses;
using PlanoSaudeOnline.Domain.PlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers;

public class ConsultarPlanoSaudeHandler : IConsultarPlanoSaudeHandler
{
    private readonly IPlanoSaudeRepository planoSaudeRepository;

    public ConsultarPlanoSaudeHandler(IPlanoSaudeRepository planoSaudeRepository)
    {
        this.planoSaudeRepository = planoSaudeRepository;
    }

    public async Task<HandlerResponse<PagedQueryResponse<IEnumerable<PlanoSaudeResponse>>>> HandleAsync(ConsultarPlanoSaudeRequest request)
    {
        var queryResult = await planoSaudeRepository.Buscar(request);

        Console.WriteLine("Handle ConsultarPlanoSaudeHandler executed!");

        if (queryResult.Items == null || !queryResult.Items.Any())
            return new HandlerResponse<PagedQueryResponse<IEnumerable<PlanoSaudeResponse>>>(System.Net.HttpStatusCode.NoContent);

        return new HandlerResponse<PagedQueryResponse<IEnumerable<PlanoSaudeResponse>>>(System.Net.HttpStatusCode.OK, queryResult.ConverterParaPlanoSaudeResponse());
    }
}
