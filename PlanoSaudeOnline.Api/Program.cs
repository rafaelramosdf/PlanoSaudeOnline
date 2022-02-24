using Microsoft.Extensions.Options;
using PlanoSaudeOnline.Api.Repositories;
using PlanoSaudeOnline.Api.Repositories.Contracts;
using PlanoSaudeOnline.Api.Services;
using PlanoSaudeOnline.Api.Services.Contracts;
using PlanoSaudeOnline.Api.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<DbPlanoSaudeOnlineConnectionString>(builder.Configuration.GetSection(nameof(DbPlanoSaudeOnlineConnectionString)));
builder.Services.AddSingleton<IDbPlanoSaudeOnlineConnectionString>(sp => sp.GetRequiredService<IOptions<DbPlanoSaudeOnlineConnectionString>>().Value);

// Repositories Injection
builder.Services.AddScoped<IOperadoraPlanoSaudeRepository, OperadoraPlanoSaudeRepository>();

// UseCases Injection
builder.Services.AddScoped<ICrudOperadoraPlanoSaudeUseCase, CrudOperadoraPlanoSaudeUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
