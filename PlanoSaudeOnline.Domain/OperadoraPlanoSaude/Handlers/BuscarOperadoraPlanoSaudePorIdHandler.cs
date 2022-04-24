using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;

public class BuscarOperadoraPlanoSaudePorIdHandler : IBuscarOperadoraPlanoSaudePorIdHandler
{
    private readonly IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository;

    public BuscarOperadoraPlanoSaudePorIdHandler(IOperadoraPlanoSaudeRepository operadoraPlanoSaudeRepository)
    {
        this.operadoraPlanoSaudeRepository = operadoraPlanoSaudeRepository;
    }

    public async Task<HandlerResponse<OperadoraPlanoSaudeResponse>> HandleAsync(string request)
    {
        return await Task.Run<HandlerResponse<OperadoraPlanoSaudeResponse>>(() => 
        {
            var operadoraPlanoSaude = operadoraPlanoSaudeRepository.Buscar(request);

            Console.WriteLine("Handle BuscarOperadoraPlanoSaudePorIdHandler executed!");

            if (operadoraPlanoSaude == null)
                return new HandlerResponse<OperadoraPlanoSaudeResponse>(System.Net.HttpStatusCode.NotFound);
            
            return new HandlerResponse<OperadoraPlanoSaudeResponse>(System.Net.HttpStatusCode.OK, 
                new OperadoraPlanoSaudeResponse(operadoraPlanoSaude));
        });
    }
}
