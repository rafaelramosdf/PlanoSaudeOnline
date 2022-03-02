using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.UseCases.Base;

namespace PlanoSaudeOnline.Api.UseCases
{
    public class CrudFaixaEtariaUseCase : CrudUseCase<FaixaEtaria, IFaixaEtariaRepository>, ICrudFaixaEtariaUseCase
    {
        public CrudFaixaEtariaUseCase(IFaixaEtariaRepository repository)
            : base(repository)
        {
        }
    }
}
