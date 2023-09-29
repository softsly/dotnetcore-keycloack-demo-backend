using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotnetKeycloakSimpleTest
{
    [ApiController]
    [Route("api/authenticated")]
    public class AuthenticatedServiceController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public string Get()
        {
            return "This is an authenticated service.";
        }
    }
}