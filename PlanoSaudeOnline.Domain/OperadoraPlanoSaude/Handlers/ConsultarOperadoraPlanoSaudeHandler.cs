using Microsoft.AspNetCore.Mvc;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class ConsultarOperadoraPlanoSaudeHandler : IConsultarOperadoraPlanoSaudeHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public ConsultarOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<HandlerResponse<PagedQueryResponse<IEnumerable<Entities.OperadoraPlanoSaude>>>> HandleAsync(ConsultarOperadoraPlanoSaudeRequest request)
    {
        var result = await operadoraPlanoSaudeRepository.Buscar(request.ObterConsulta(), request.Page, request.Limit);

        if (result.Items == null || !result.Items.Any())
            return new HandlerResponse<PagedQueryResponse<IEnumerable<Entities.OperadoraPlanoSaude>>>(System.Net.HttpStatusCode.NoContent);

        return new HandlerResponse<PagedQueryResponse<IEnumerable<Entities.OperadoraPlanoSaude>>>(System.Net.HttpStatusCode.OK, result);
    }
}
