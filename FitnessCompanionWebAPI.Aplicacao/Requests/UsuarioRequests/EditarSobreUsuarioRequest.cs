using MediatR;
using System;

namespace FitnessCompanionWebAPI.Aplicacao.Requests.UsuarioRequests
{
    public class EditarSobreUsuarioRequest : IRequest
    {
        public Guid Id { get; set; }
        public string Sobre { get; set; }
    }
}
