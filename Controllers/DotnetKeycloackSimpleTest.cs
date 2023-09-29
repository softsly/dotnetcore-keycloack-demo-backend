using Microsoft.AspNetCore.Mvc;

namespace DotnetKeycloakSimpleTest
{
    [ApiController]
    [Route("api/unauthenticated")]
    public class UnauthenticatedServiceController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "This is an unauthenticated service.";
        }
    }
}