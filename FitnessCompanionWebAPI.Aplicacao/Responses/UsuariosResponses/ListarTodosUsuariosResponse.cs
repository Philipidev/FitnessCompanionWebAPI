using FitnessCompanionWebAPI.Aplicacao.Dtos.UsuarioDtos;
using MediatR;
using System.Collections.Generic;

namespace FitnessCompanionWebAPI.Aplicacao.Responses.UsuariosResponses
{
    public class ListarTodosUsuariosResponse : IRequest<ListarTodosUsuariosResponse>
    {
        public IEnumerable<UsuarioDto> Usuarios { get; set; }
    }
}
