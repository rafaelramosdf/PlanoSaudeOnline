using Microsoft.Extensions.Options;
using PlanoSaudeOnline.Domain.Cotacao.Repositories;
using PlanoSaudeOnline.Domain.CotacaoVida.Repositories;
using PlanoSaudeOnline.Domain.FaixaEtaria.Repositories;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Repositories;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Contracts;
using PlanoSaudeOnline.Domain.PlanoSaude.Repositories;
using PlanoSaudeOnline.Domain.RedeEstabelecimento.Repositories;
using PlanoSaudeOnline.Domain.Usuario.Repositories;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;

namespace PlanoSaudeOnline.Api.Extensions;

public static class DependencyInjectionExtension
{
    public static void AddDependencies(this WebApplicationBuilder builder)
    {
        /// <summary>
        /// Repositories Injection
        /// </summary>

        builder.Services.Configure<DbPlanoSaudeOnlineConnectionString>(builder.Configuration.GetSection(nameof(DbPlanoSaudeOnlineConnectionString)));
        builder.Services.AddSingleton<IDbPlanoSaudeOnlineConnectionString>(sp => sp.GetRequiredService<IOptions<DbPlanoSaudeOnlineConnectionString>>().Value);

        builder.Services.AddScoped<ICotacaoRepository, CotacaoRepository>();
        builder.Services.AddScoped<ICotacaoVidaRepository, CotacaoVidaRepository>();
        builder.Services.AddScoped<IFaixaEtariaRepository, FaixaEtariaRepository>();
        builder.Services.AddScoped<IOperadoraPlanoSaudeRepository, OperadoraPlanoSaudeRepository>();
        builder.Services.AddScoped<IPlanoSaudeRepository, PlanoSaudeRepository>();
        builder.Services.AddScoped<IRedeEstabelecimentoRepository, RedeEstabelecimentoRepository>();
        builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        builder.Services.AddScoped<IValorComercialMensalidadeRepository, ValorComercialMensalidadeRepository>();

        /// <summary>
        /// Handlers Injection
        /// </summary>
        
        // OperadoraPlanoSaude
        builder.Services.AddScoped<IIncluirOperadoraPlanoSaudeHandler, IncluirOperadoraPlanoSaudeHandler>();
        builder.Services.AddScoped<IConsultarOperadoraPlanoSaudeHandler, ConsultarOperadoraPlanoSaudeHandler>();
        builder.Services.AddScoped<IAlterarOperadoraPlanoSaudeHandler, AlterarOperadoraPlanoSaudeHandler>();
        builder.Services.AddScoped<IExcluirOperadoraPlanoSaudeHandler, ExcluirOperadoraPlanoSaudeHandler>();
        builder.Services.AddScoped<IBuscarOperadoraPlanoSaudePorIdHandler, BuscarOperadoraPlanoSaudePorIdHandler>();

        // PlanoSaude
        builder.Services.AddScoped<IIncluirPlanoSaudeHandler, IncluirPlanoSaudeHandler>();
        builder.Services.AddScoped<IConsultarPlanoSaudeHandler, ConsultarPlanoSaudeHandler>();
        builder.Services.AddScoped<IAlterarPlanoSaudeHandler, AlterarPlanoSaudeHandler>();
        builder.Services.AddScoped<IExcluirPlanoSaudeHandler, ExcluirPlanoSaudeHandler>();
        builder.Services.AddScoped<IBuscarPlanoSaudePorIdHandler, BuscarPlanoSaudePorIdHandler>();
        builder.Services.AddScoped<IAtualizarTagsPlanoSaudeHandler, AtualizarTagsPlanoSaudeHandler>();
    }
}
