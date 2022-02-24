using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Services.Contracts;
using PlanoSaudeOnline.Api.UseCases.Base;

namespace PlanoSaudeOnline.Api.Services
{
    public class CrudOperadoraPlanoSaudeUseCase : CrudUseCase<OperadoraPlanoSaude, IOperadoraPlanoSaudeRepository>, ICrudOperadoraPlanoSaudeUseCase
    {
        public CrudOperadoraPlanoSaudeUseCase(IOperadoraPlanoSaudeRepository repository)
            : base(repository)
        {
        }
    }
}
