using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class AlterarOperadoraPlanoSaudeHandler : IAlterarOperadoraPlanoSaudeHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public AlterarOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<HandlerResponse> HandleAsync(AlterarOperadoraPlanoSaudeRequest request)
    {
        return await Task.Run<HandlerResponse>(() => 
        {
            operadoraPlanoSaudeRepository.Alterar(request.Id, new Entities.OperadoraPlanoSaude(request));
            Console.WriteLine("Handle AlterarOperadoraPlanoSaudeCommandHandler executed!");
            return new HandlerResponse(System.Net.HttpStatusCode.NoContent);
        });
    }
}
