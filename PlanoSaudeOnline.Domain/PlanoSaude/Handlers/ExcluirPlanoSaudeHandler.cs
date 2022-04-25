using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.PlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers;

public class ExcluirPlanoSaudeHandler : IExcluirPlanoSaudeHandler
{
    private readonly IPlanoSaudeRepository planoSaudeRepository;

    public ExcluirPlanoSaudeHandler(IPlanoSaudeRepository planoSaudeRepository)
    {
        this.planoSaudeRepository = planoSaudeRepository;
    }

    public async Task<HandlerResponse> HandleAsync(string request)
    {
        return await Task.Run(() =>
        {
            planoSaudeRepository.Remover(request);

            Console.WriteLine("Handle ExcluirPlanoSaudeHandler executed!");

            return new HandlerResponse(System.Net.HttpStatusCode.NoContent);
        });
    }
}
