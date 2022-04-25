using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Repositories;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers;

public class ExcluirValorComercialMensalidadeHandler : IExcluirValorComercialMensalidadeHandler
{
    private readonly IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository;

    public ExcluirValorComercialMensalidadeHandler(IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository)
    {
        this.ValorComercialMensalidadeRepository = ValorComercialMensalidadeRepository;
    }

    public async Task<HandlerResponse> HandleAsync(string request)
    {
        return await Task.Run(() =>
        {
            ValorComercialMensalidadeRepository.Remover(request);

            Console.WriteLine("Handle ExcluirValorComercialMensalidadeHandler executed!");

            return new HandlerResponse(System.Net.HttpStatusCode.NoContent);
        });
    }
}
