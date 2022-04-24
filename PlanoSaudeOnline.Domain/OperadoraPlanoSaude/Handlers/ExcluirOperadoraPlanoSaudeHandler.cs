using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class ExcluirOperadoraPlanoSaudeHandler : IExcluirOperadoraPlanoSaudeHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public ExcluirOperadoraPlanoSaudeHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<HandlerResponse> HandleAsync(string request)
    {
        return await Task.Run<HandlerResponse>(() => 
        {
            operadoraPlanoSaudeRepository.Remover(request);

            Console.WriteLine("Handle ExcluirOperadoraPlanoSaudeCommandHandler executed!");
            
            return new HandlerResponse(System.Net.HttpStatusCode.NoContent);
        });
    }
}
