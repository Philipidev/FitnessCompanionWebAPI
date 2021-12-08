using MediatR;
using System;

namespace FitnessCompanionWebAPI.Aplicacao.Requests.UsuarioRequests
{
    public class EditarImagemUsuarioRequest : IRequest
    {
        public Guid Id { get; set; }
        public string Imagem { get; set; }
    }
}
