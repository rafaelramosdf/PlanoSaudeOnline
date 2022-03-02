﻿using PlanoSaudeOnline.Api.Models;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.UseCases.Base;

namespace PlanoSaudeOnline.Api.UseCases
{
    public class CrudRedeEstabelecimentoUseCase : CrudUseCase<RedeEstabelecimento, IRedeEstabelecimentoRepository>, ICrudRedeEstabelecimentoUseCase
    {
        public CrudRedeEstabelecimentoUseCase(IRedeEstabelecimentoRepository repository)
            : base(repository)
        {
        }
    }
}
