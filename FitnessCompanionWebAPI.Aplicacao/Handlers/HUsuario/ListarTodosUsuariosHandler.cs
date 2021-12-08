using AutoMapper;
using FitnessCompanionWebAPI.Aplicacao.Dtos.UsuarioDtos;
using FitnessCompanionWebAPI.Aplicacao.Repositorios;
using FitnessCompanionWebAPI.Aplicacao.Responses.UsuariosResponses;
using FitnessCompanionWebAPI.Dominio.Entidades;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Aplicacao.Handlers.HUsuario
{
    public class ListarTodosUsuariosHandler : IRequestHandler<ListarTodosUsuariosResponse, ListarTodosUsuariosResponse>
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;
        private readonly IMapper mapper;

        public ListarTodosUsuariosHandler(IUsuarioRepositorio usuarioRepositorio, IMapper mapper)
        {
            this.usuarioRepositorio = usuarioRepositorio;
            this.mapper = mapper;
        }

        public Task<ListarTodosUsuariosResponse> Handle(ListarTodosUsuariosResponse request, CancellationToken cancellationToken)
        {
            IEnumerable<Usuario> usuarios = usuarioRepositorio.Listar();

            return Task.FromResult(new ListarTodosUsuariosResponse()
            {
                Usuarios = mapper.Map<IEnumerable<UsuarioDto>>(usuarios),
            });
        }
    }
}
