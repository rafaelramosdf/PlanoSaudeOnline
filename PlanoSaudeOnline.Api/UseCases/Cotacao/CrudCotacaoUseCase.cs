using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.UseCases.Base;

namespace PlanoSaudeOnline.Api.UseCases
{
    public class CrudCotacaoUseCase : CrudUseCase<Cotacao, ICotacaoRepository>, ICrudCotacaoUseCase
    {
        public CrudCotacaoUseCase(ICotacaoRepository repository)
            : base(repository)
        {
        }
    }
}
