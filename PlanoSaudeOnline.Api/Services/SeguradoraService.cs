using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Services.Contracts;

namespace PlanoSaudeOnline.Api.Services
{
    public class SeguradoraService : ISeguradoraService
    {
        private readonly ISeguradoraRepository seguradoraRepository;

        public SeguradoraService(ISeguradoraRepository seguradoraRepository)
        {
            this.seguradoraRepository = seguradoraRepository;
        }

        public Seguradora Incluir(Seguradora seguradora)
        {
            return seguradoraRepository.Create(seguradora);
        }

        public void Alterar(string id, Seguradora seguradora)
        {
            seguradoraRepository.Update(id, seguradora);
        }

        public void Excluir(string id)
        {
            seguradoraRepository.Remove(id);
        }

        public void Excluir(Seguradora seguradora)
        {
            seguradoraRepository.Remove(seguradora);
        }

        public Seguradora ListarPorId(string id)
        {
            return seguradoraRepository.Get(id);
        }

        public List<Seguradora> ListarTodos()
        {
            return seguradoraRepository.Get();
        }
    }
}
