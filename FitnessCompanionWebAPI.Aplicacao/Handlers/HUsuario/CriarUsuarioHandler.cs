using FitnessCompanionWebAPI.Aplicacao.Repositorios;
using FitnessCompanionWebAPI.Aplicacao.Requests.UsuarioRequests;
using FitnessCompanionWebAPI.Aplicacao.Responses.UsuariosResponses;
using FitnessCompanionWebAPI.Dominio.Entidades;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Aplicacao.Handlers.HUsuario
{
    public class CriarUsuarioHandler : IRequestHandler<CriarUsuarioRequest, CriarUsuarioResponse>
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;

        public CriarUsuarioHandler(IUsuarioRepositorio usuarioRepositorio)
        {
            this.usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<CriarUsuarioResponse> Handle(CriarUsuarioRequest request, CancellationToken cancellationToken)
        {
            Usuario usuario = await usuarioRepositorio.InserirAsync(new Usuario()
            {
                Nome = request.Nome,
                Email = request.Email,
                Senha = CriptBCrypt.CriptBCrypt.Criptografar(request.Senha),
                Sobrenome = request.Sobrenome,
            }, cancellationToken);

            return new CriarUsuarioResponse()
            {
                Id = usuario.Id,
            };
        }
    }
}
