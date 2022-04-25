using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.PlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers;

public class AlterarPlanoSaudeHandler : IAlterarPlanoSaudeHandler
{
    private readonly IPlanoSaudeRepository planoSaudeRepository;

    public AlterarPlanoSaudeHandler(IPlanoSaudeRepository planoSaudeRepository)
    {
        this.planoSaudeRepository = planoSaudeRepository;
    }

    public async Task<HandlerResponse> HandleAsync(AlterarPlanoSaudeRequest request)
    {
        return await Task.Run<HandlerResponse>(() =>
        {
            planoSaudeRepository.Alterar(request.Id, new Entities.PlanoSaude(request));

            Console.WriteLine("Handle AlterarPlanoSaudeHandler executed!");

            return new HandlerResponse(System.Net.HttpStatusCode.NoContent);
        });
    }
}
