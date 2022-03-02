using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.UseCases.Base;

namespace PlanoSaudeOnline.Api.UseCases
{
    public class CrudUsuarioUseCase : CrudUseCase<Usuario, IUsuarioRepository>, ICrudUsuarioUseCase
    {
        public CrudUsuarioUseCase(IUsuarioRepository repository)
            : base(repository)
        {
        }
    }
}
