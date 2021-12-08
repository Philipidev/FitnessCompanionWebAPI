using FitnessCompanionWebAPI.Aplicacao.Responses.UsuariosResponses;
using MediatR;
using System;

namespace FitnessCompanionWebAPI.Aplicacao.Requests.UsuarioRequests
{
    public class ObterUsuarioRequest : IRequest<ObterUsuarioResponse>
    {
        public Guid Id { get; set; }
    }
}
