using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Contracts;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Requests;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Repositories;

namespace PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers;

public class AlterarValorComercialMensalidadeHandler : IAlterarValorComercialMensalidadeHandler
{
    private readonly IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository;

    public AlterarValorComercialMensalidadeHandler(IValorComercialMensalidadeRepository ValorComercialMensalidadeRepository)
    {
        this.ValorComercialMensalidadeRepository = ValorComercialMensalidadeRepository;
    }

    public async Task<HandlerResponse> HandleAsync(AlterarValorComercialMensalidadeRequest request)
    {
        return await Task.Run<HandlerResponse>(() =>
        {
            ValorComercialMensalidadeRepository.Alterar(request.Id, new Entities.ValorComercialMensalidade(request));

            Console.WriteLine("Handle AlterarValorComercialMensalidadeHandler executed!");

            return new HandlerResponse(System.Net.HttpStatusCode.NoContent);
        });
    }
}
