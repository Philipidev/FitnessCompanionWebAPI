using FitnessCompanionWebAPI.Aplicacao.Exceptions;
using FitnessCompanionWebAPI.Aplicacao.Repositorios;
using FitnessCompanionWebAPI.Aplicacao.Requests.AuthRequests;
using FitnessCompanionWebAPI.Aplicacao.Responses.LoginResponses;
using FitnessCompanionWebAPI.Dominio.Entidades;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Aplicacao.Handlers.HAuth
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;

        public LoginHandler(IUsuarioRepositorio usuarioRepositorio)
        {
            this.usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            Usuario usuario = await usuarioRepositorio.ObterPorEmail(request.Email, cancellationToken);

            if (!CriptBCrypt.CriptBCrypt.Validar(request.Senha, usuario.Senha))
            {
                throw new SenhaInvalidaException("Senha inválida");
            }

            return new LoginResponse()
            {
                Id = usuario.Id,
                Token = $"token:{usuario.Id}"
            };
        }
    }
}
