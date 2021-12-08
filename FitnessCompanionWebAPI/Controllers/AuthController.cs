using FitnessCompanionWebAPI.Aplicacao.Requests.AuthRequests;
using FitnessCompanionWebAPI.Aplicacao.Responses.LoginResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Controllers
{
    public class AuthController : ApiController
    {
        /// <summary>
        /// realizar login
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("api/[controller]/Login")]
        [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status200OK)]
        public async Task<ObjectResult> Login([FromBody] LoginRequest request, CancellationToken cancellationToken)
        {
            LoginResponse resultado = await Mediator.Send(request, cancellationToken);

            return new ObjectResult(resultado)
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
