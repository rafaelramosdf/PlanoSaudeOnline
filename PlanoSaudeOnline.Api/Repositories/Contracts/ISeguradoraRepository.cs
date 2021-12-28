using PlanoSaudeOnline.Api.Models;

namespace PlanoSaudeOnline.Api.Repositories.Contracts
{
    public interface ISeguradoraRepository
    {
        List<Seguradora> Get();
        Seguradora Get(string id);
        Seguradora Create(Seguradora seguradora);
        void Update(string id, Seguradora seguradoraIn);
        void Remove(Seguradora seguradoraIn);
        void Remove(string id);
    }
}
