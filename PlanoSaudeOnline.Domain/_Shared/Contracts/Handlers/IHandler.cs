using PlanoSaudeOnline.Domain._Shared.Base.Handlers;

namespace PlanoSaudeOnline.Domain._Shared.Contracts.Handlers;

public interface IHandler<THandlerResponse> 
    where THandlerResponse : IHandlerResponse
{
    THandlerResponse Handle();
}

public interface IHandler<THandlerResponse, TRequest>
    where THandlerResponse : IHandlerResponse
{
    THandlerResponse Handle(TRequest request);
}

public interface IHandlerAsync<THandlerResponse>
    where THandlerResponse : IHandlerResponse
{
    Task<THandlerResponse> HandleAsync();
}

public interface IHandlerAsync<THandlerResponse, TRequest>
    where THandlerResponse : IHandlerResponse
{
    Task<THandlerResponse> HandleAsync(TRequest request);
}
