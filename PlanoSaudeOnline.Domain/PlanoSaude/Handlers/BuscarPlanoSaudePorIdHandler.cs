using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Responses;
using PlanoSaudeOnline.Domain.PlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers;

public class BuscarPlanoSaudePorIdHandler : IBuscarPlanoSaudePorIdHandler
{
    private readonly IPlanoSaudeRepository planoSaudeRepository;

    public BuscarPlanoSaudePorIdHandler(IPlanoSaudeRepository planoSaudeRepository)
    {
        this.planoSaudeRepository = planoSaudeRepository;
    }

    public async Task<HandlerResponse<PlanoSaudeResponse>> HandleAsync(string request)
    {
        return await Task.Run(() =>
        {
            var planoSaude = planoSaudeRepository.Buscar(request);

            Console.WriteLine("Handle BuscarPlanoSaudePorIdHandler executed!");

            if (planoSaude == null)
                return new HandlerResponse<PlanoSaudeResponse>(System.Net.HttpStatusCode.NotFound);

            return new HandlerResponse<PlanoSaudeResponse>(
                System.Net.HttpStatusCode.OK,
                new PlanoSaudeResponse(planoSaude));
        });
    }
}
