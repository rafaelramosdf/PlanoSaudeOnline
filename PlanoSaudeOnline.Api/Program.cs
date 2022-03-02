using Microsoft.Extensions.Options;
using PlanoSaudeOnline.Api.Repositories;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Settings;
using PlanoSaudeOnline.Api.UseCases;

var builder = WebApplication.CreateBuilder(args);

/// <summary>
/// Services Configurations
/// </summary>

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.Configure<DbPlanoSaudeOnlineConnectionString>(builder.Configuration.GetSection(nameof(DbPlanoSaudeOnlineConnectionString)));

builder.Services.AddSingleton<IDbPlanoSaudeOnlineConnectionString>(sp => sp.GetRequiredService<IOptions<DbPlanoSaudeOnlineConnectionString>>().Value);

/// <summary>
/// Repositories Injection
/// </summary>

builder.Services.AddScoped<ICotacaoRepository, CotacaoRepository>();
builder.Services.AddScoped<ICotacaoVidaRepository, CotacaoVidaRepository>();
builder.Services.AddScoped<IFaixaEtariaRepository, FaixaEtariaRepository>();
builder.Services.AddScoped<IOperadoraPlanoSaudeRepository, OperadoraPlanoSaudeRepository>();
builder.Services.AddScoped<IPlanoSaudeRepository, PlanoSaudeRepository>();
builder.Services.AddScoped<IRedeEstabelecimentoRepository, RedeEstabelecimentoRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IValorComercialMensalidadeRepository, ValorComercialMensalidadeRepository>();

/// <summary>
/// UseCases Injection
/// </summary>

builder.Services.AddScoped<ICrudCotacaoUseCase, CrudCotacaoUseCase>();
builder.Services.AddScoped<ICrudCotacaoVidaUseCase, CrudCotacaoVidaUseCase>();
builder.Services.AddScoped<ICrudFaixaEtariaUseCase, CrudFaixaEtariaUseCase>();
builder.Services.AddScoped<ICrudOperadoraPlanoSaudeUseCase, CrudOperadoraPlanoSaudeUseCase>();
builder.Services.AddScoped<ICrudPlanoSaudeUseCase, CrudPlanoSaudeUseCase>();
builder.Services.AddScoped<ICrudRedeEstabelecimentoUseCase, CrudRedeEstabelecimentoUseCase>();
builder.Services.AddScoped<ICrudUsuarioUseCase, CrudUsuarioUseCase>();
builder.Services.AddScoped<ICrudValorComercialMensalidadeUseCase, CrudValorComercialMensalidadeUseCase>();

/// <summary>
/// App Configurations:
/// </summary>

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
