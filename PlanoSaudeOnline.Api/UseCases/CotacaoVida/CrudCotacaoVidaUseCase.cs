using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.UseCases.Base;

namespace PlanoSaudeOnline.Api.UseCases
{
    public class CrudCotacaoVidaUseCase : CrudUseCase<CotacaoVida, ICotacaoVidaRepository>, ICrudCotacaoVidaUseCase
    {
        public CrudCotacaoVidaUseCase(ICotacaoVidaRepository repository)
            : base(repository)
        {
        }
    }
}
