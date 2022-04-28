using PlanoSaudeOnline.Domain._Shared.Base.Handlers;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Requests;
using PlanoSaudeOnline.Domain.PlanoSaude.Repositories;
using System.Net;

namespace PlanoSaudeOnline.Domain.PlanoSaude.Handlers;

public class AtualizarTagsPlanoSaudeHandler : IAtualizarTagsPlanoSaudeHandler
{
    private readonly IPlanoSaudeRepository planoSaudeRepository;
    private readonly IAlterarPlanoSaudeHandler alterarPlanoSaudeHandler;

    public AtualizarTagsPlanoSaudeHandler(
        IPlanoSaudeRepository planoSaudeRepository,
        IAlterarPlanoSaudeHandler alterarPlanoSaudeHandler)
    {
        this.planoSaudeRepository = planoSaudeRepository;
        this.alterarPlanoSaudeHandler = alterarPlanoSaudeHandler;
    }

    public async Task<HandlerResponse> HandleAsync()
    {
        Console.WriteLine("Handle AtualizarTagsPlanoSaudeHandler started!");

        var planoSaudeResult = await planoSaudeRepository.BuscarTodos();

        if (planoSaudeResult != null && planoSaudeResult.Items != null) 
        {
            int itensAtualizados = 0;
            int itensNaoAtualizados = 0;
            int totalItens = planoSaudeResult.Items.Count();

            foreach (var item in planoSaudeResult.Items)
            {
                var itemAtualizado = new AlterarPlanoSaudeRequest(item);
                try
                {
                    var alterarPlanoSaudeResult = await alterarPlanoSaudeHandler.HandleAsync(itemAtualizado);
                    if (alterarPlanoSaudeResult != null && alterarPlanoSaudeResult.StatusCode == HttpStatusCode.NoContent.GetHashCode())
                        itensAtualizados++;
                    else
                        itensNaoAtualizados++;
                }
                catch (Exception)
                {
                    itensNaoAtualizados++;
                    Console.WriteLine($"Handle AtualizarTagsPlanoSaudeHandler - Erro ao tentar atualizar o PlanoSaude: {item.Id}");
                }
            }

            Console.WriteLine($"Total de itens: {totalItens} | Itens atualizados: {itensAtualizados} | Itens com erro: {itensNaoAtualizados}");
        }

        Console.WriteLine("Handle AtualizarTagsPlanoSaudeHandler executed!");

        return new HandlerResponse(System.Net.HttpStatusCode.NoContent);
    }
}
