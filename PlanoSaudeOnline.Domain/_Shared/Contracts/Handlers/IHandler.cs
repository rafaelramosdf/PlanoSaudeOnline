using Microsoft.AspNetCore.Mvc;

namespace PlanoSaudeOnline.Domain._Shared.Contracts.Handlers;

public interface IHandler
{
    IActionResult Handle();
}

public interface IHandler<TRequest>
{
    IActionResult Handle(TRequest request);
}

public interface IHandlerAsync
{
    Task<IActionResult> HandleAsync();
}

public interface IHandlerAsync<TRequest>
{
    Task<IActionResult> HandleAsync(TRequest request);
}
