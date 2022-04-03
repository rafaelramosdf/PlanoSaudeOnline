using Microsoft.AspNetCore.Mvc;

namespace PlanoSaudeOnline.Api.Controllers.v1.Base
{
    [ApiController]
    [ApiVersion("1")]
    [Produces("application/json")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public abstract class BaseController : ControllerBase
    {
    }
}
