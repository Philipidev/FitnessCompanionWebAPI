using FitnessCompanionWebAPI.Aplicacao.Repositorios;
using FitnessCompanionWebAPI.Aplicacao.Requests.UsuarioRequests;
using FitnessCompanionWebAPI.Dominio.Entidades;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Aplicacao.Handlers.HUsuario
{
    public class EditarSobreUsuarioHandler : IRequestHandler<EditarSobreUsuarioRequest>
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;

        public EditarSobreUsuarioHandler(IUsuarioRepositorio usuarioRepositorio)
        {
            this.usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<Unit> Handle(EditarSobreUsuarioRequest request, CancellationToken cancellationToken)
        {
            Usuario usuario = await usuarioRepositorio.Obter(request.Id, cancellationToken);
            usuario.Sobre = request.Sobre;
            await usuarioRepositorio.Editar(usuario, cancellationToken);

            return Unit.Value;
        }
    }
}
