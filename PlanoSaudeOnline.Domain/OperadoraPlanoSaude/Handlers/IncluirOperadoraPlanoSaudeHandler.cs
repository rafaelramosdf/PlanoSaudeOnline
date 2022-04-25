using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class IncluirOperadoraPlanoSaudeHandler : IIncluirOperadoraPlanoSaudeHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public IncluirOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<HandlerResponse<OperadoraPlanoSaudeResponse>> HandleAsync(IncluirOperadoraPlanoSaudeRequest request)
    {
        return await Task.Run<HandlerResponse<OperadoraPlanoSaudeResponse>>(() => 
        {
            var operadoraPlanoSaude = new Entities.OperadoraPlanoSaude(request);

            if (!operadoraPlanoSaude.IsValid)
                return new HandlerResponse<OperadoraPlanoSaudeResponse>(System.Net.HttpStatusCode.BadRequest, operadoraPlanoSaude.Notifications);

            operadoraPlanoSaude = operadoraPlanoSaudeRepository.Inserir(operadoraPlanoSaude);

            Console.WriteLine("Handle IncluirOperadoraPlanoSaudeHandler executed!");

            return new HandlerResponse<OperadoraPlanoSaudeResponse>(System.Net.HttpStatusCode.Created, new OperadoraPlanoSaudeResponse(operadoraPlanoSaude));
        });
    }
}
