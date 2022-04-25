using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Responses;
using PlanoSaudeOnline.Domain.PlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers;

public class IncluirPlanoSaudeHandler : IIncluirPlanoSaudeHandler
{
    private readonly IPlanoSaudeRepository planoSaudeRepository;

    public IncluirPlanoSaudeHandler(IPlanoSaudeRepository planoSaudeRepository)
    {
        this.planoSaudeRepository = planoSaudeRepository;
    }

    public async Task<HandlerResponse<PlanoSaudeResponse>> HandleAsync(IncluirPlanoSaudeRequest request)
    {
        return await Task.Run<HandlerResponse<PlanoSaudeResponse>>(() =>
        {
            var planoSaude = new Entities.PlanoSaude(request);

            planoSaude = planoSaudeRepository.Inserir(planoSaude);

            Console.WriteLine("Handle IncluirPlanoSaudeHandler executed!");

            return new HandlerResponse<PlanoSaudeResponse>(System.Net.HttpStatusCode.Created, new PlanoSaudeResponse(planoSaude));
        });
    }
}
