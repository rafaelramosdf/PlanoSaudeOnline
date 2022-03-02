using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.UseCases.Base;

namespace PlanoSaudeOnline.Api.UseCases
{
    public class CrudValorComercialMensalidadeUseCase : CrudUseCase<ValorComercialMensalidade, IValorComercialMensalidadeRepository>, ICrudValorComercialMensalidadeUseCase
    {
        public CrudValorComercialMensalidadeUseCase(IValorComercialMensalidadeRepository repository)
            : base(repository)
        {
        }
    }
}
