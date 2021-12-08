using FitnessCompanionWebAPI.Aplicacao.Repositorios;
using FitnessCompanionWebAPI.Aplicacao.Requests.UsuarioRequests;
using FitnessCompanionWebAPI.Dominio.Entidades;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Aplicacao.Handlers.HUsuario
{
    public class EditarImagemUsuarioHandler : IRequestHandler<EditarImagemUsuarioRequest>
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;

        public EditarImagemUsuarioHandler(IUsuarioRepositorio usuarioRepositorio)
        {
            this.usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<Unit> Handle(EditarImagemUsuarioRequest request, CancellationToken cancellationToken)
        {
            Usuario usuario = await usuarioRepositorio.Obter(request.Id, cancellationToken);
            usuario.Avatar = request.Imagem;
            await usuarioRepositorio.Editar(usuario, cancellationToken);

            return Unit.Value;
        }
    }
}
