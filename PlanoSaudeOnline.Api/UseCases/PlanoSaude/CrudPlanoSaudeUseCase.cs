using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.UseCases.Base;

namespace PlanoSaudeOnline.Api.UseCases
{
    public class CrudPlanoSaudeUseCase : CrudUseCase<PlanoSaude, IPlanoSaudeRepository>, ICrudPlanoSaudeUseCase
    {
        public CrudPlanoSaudeUseCase(IPlanoSaudeRepository repository)
            : base(repository)
        {
        }
    }
}
