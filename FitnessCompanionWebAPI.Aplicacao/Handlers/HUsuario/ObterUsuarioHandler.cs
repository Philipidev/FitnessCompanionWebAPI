using AutoMapper;
using FitnessCompanionWebAPI.Aplicacao.Dtos.UsuarioDtos;
using FitnessCompanionWebAPI.Aplicacao.Repositorios;
using FitnessCompanionWebAPI.Aplicacao.Requests.UsuarioRequests;
using FitnessCompanionWebAPI.Aplicacao.Responses.UsuariosResponses;
using FitnessCompanionWebAPI.Dominio.Entidades;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Aplicacao.Handlers.HUsuario
{
    public class ObterUsuarioHandler : IRequestHandler<ObterUsuarioRequest, ObterUsuarioResponse>
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;
        private readonly IMapper mapper;

        public ObterUsuarioHandler(IUsuarioRepositorio usuarioRepositorio, IMapper mapper)
        {
            this.usuarioRepositorio = usuarioRepositorio;
            this.mapper = mapper;
        }

        public async Task<ObterUsuarioResponse> Handle(ObterUsuarioRequest request, CancellationToken cancellationToken)
        {
            Usuario usuario = await usuarioRepositorio.Obter(request.Id, cancellationToken);

            return new ObterUsuarioResponse()
            {
                Usuario = mapper.Map<UsuarioDto>(usuario),
            };
        }
    }
}
