using Flunt.Notifications;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace PlanoSaudeOnline.Domain._Shared.Base.Handlers;

public interface IHandlerResponse { }

public class HandlerResponse<TResultObject> : ObjectResult, IHandlerResponse
{
    public HandlerResponse(HttpStatusCode statusCode, TResultObject? objectResult)
        : base(objectResult)
    {
        base.StatusCode = statusCode.GetHashCode();
    }

    public HandlerResponse(HttpStatusCode statusCode, IEnumerable<Notification> notifications)
        : base(notifications)
    {
        base.StatusCode = statusCode.GetHashCode();
    }

    public HandlerResponse(HttpStatusCode statusCode)
        : base(null)
    {
        base.StatusCode = statusCode.GetHashCode();
    }
}

public class HandlerResponse : StatusCodeResult, IHandlerResponse
{
    public HandlerResponse(HttpStatusCode statusCode)
        : base(statusCode.GetHashCode())
    {
    }
}