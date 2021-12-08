using FitnessCompanionWebAPI.Aplicacao.Requests.UsuarioRequests;
using FitnessCompanionWebAPI.Aplicacao.Responses.UsuariosResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        /// <summary>
        /// Endpoint para criar um novo usuario
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("api/[controller]/CriarUsuario")]
        [ProducesResponseType(typeof(CriarUsuarioResponse), StatusCodes.Status200OK)]
        public async Task<ObjectResult> CriarUsuario([FromBody] CriarUsuarioRequest request, CancellationToken cancellationToken)
        {
            CriarUsuarioResponse resultado = await Mediator.Send(request, cancellationToken);

            return new ObjectResult(resultado)
            {
                StatusCode = StatusCodes.Status200OK,
            };
        }

        /// <summary>
        /// Endpoint listar todos os usuarios
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("api/[controller]/ListarTodosUsuarios")]
        [ProducesResponseType(typeof(ListarTodosUsuariosResponse), StatusCodes.Status200OK)]
        public async Task<ObjectResult> ListarTodosUsuarios(CancellationToken cancellationToken)
        {
            ListarTodosUsuariosResponse resultado = await Mediator.Send(new ListarTodosUsuariosResponse(), cancellationToken);

            return new ObjectResult(resultado)
            {
                StatusCode = StatusCodes.Status200OK,
            };
        }

        /// <summary>
        /// Endpoint para obter um usuario e suas informacoes
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("api/[controller]/ObterUsuario")]
        [ProducesResponseType(typeof(ObterUsuarioResponse), StatusCodes.Status200OK)]
        public async Task<ObjectResult> ObterUsuario([FromQuery] ObterUsuarioRequest request, CancellationToken cancellationToken)
        {
            ObterUsuarioResponse resultado = await Mediator.Send(request, cancellationToken);

            return new ObjectResult(resultado)
            {
                StatusCode = StatusCodes.Status200OK,
            };
        }

        /// <summary>
        /// Endpoint editar o sobre de um determinado usuario
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPut("api/[controller]/EditarSobreUsuario")]
        [ProducesResponseType(typeof(NoContentResult), StatusCodes.Status204NoContent)]
        public async Task<NoContentResult> EditarSobreUsuario([FromBody] EditarSobreUsuarioRequest request, CancellationToken cancellationToken)
        {
            await Mediator.Send(request, cancellationToken);

            return new NoContentResult();
        }

        /// <summary>
        /// Endpoint editar o sobre de um determinado usuario
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPut("api/[controller]/EditarImagemUsuario")]
        [ProducesResponseType(typeof(NoContentResult), StatusCodes.Status204NoContent)]
        public async Task<NoContentResult> EditarImagemUsuario([FromBody] EditarImagemUsuarioRequest request, CancellationToken cancellationToken)
        {
            await Mediator.Send(request, cancellationToken);

            return new NoContentResult();
        }
    }
}
