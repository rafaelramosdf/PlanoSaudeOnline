using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class ConsultarOperadoraPlanoSaudeHandler : IConsultarOperadoraPlanoSaudeHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public ConsultarOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<HandlerResponse<PagedQueryResponse<IEnumerable<OperadoraPlanoSaudeResponse>>>> HandleAsync(ConsultarOperadoraPlanoSaudeRequest request)
    {
        var queryResult = await operadoraPlanoSaudeRepository.Buscar(request);

        Console.WriteLine("Handle ConsultarOperadoraPlanoSaudeHandler executed!");

        if (queryResult.Items == null || !queryResult.Items.Any())
            return new HandlerResponse<PagedQueryResponse<IEnumerable<OperadoraPlanoSaudeResponse>>>(System.Net.HttpStatusCode.NoContent);

        return new HandlerResponse<PagedQueryResponse<IEnumerable<OperadoraPlanoSaudeResponse>>>(System.Net.HttpStatusCode.OK, queryResult.ConverterParaOperadoraPlanoSaudeResponse());
    }
}
