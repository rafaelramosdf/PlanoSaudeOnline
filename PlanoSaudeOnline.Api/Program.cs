using MediatR;
using Microsoft.Extensions.Options;
using PlanoSaudeOnline.Domain.Contracts.Repositories;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB;
using PlanoSaudeOnline.Infrastructure.Repositories.MongoDB.Base;
using System.Reflection;

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
/// MediatR Injection
/// </summary>
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

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
