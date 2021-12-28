using PlanoSaudeOnline.Api.Models;

namespace PlanoSaudeOnline.Api.Services.Contracts
{
    public interface ISeguradoraService
    {
        Seguradora Incluir(Seguradora seguradora);
        void Alterar(string id, Seguradora seguradora);
        void Excluir(string id);
        void Excluir(Seguradora seguradora);

        Seguradora ListarPorId(string id);
        List<Seguradora> ListarTodos();
    }
}
