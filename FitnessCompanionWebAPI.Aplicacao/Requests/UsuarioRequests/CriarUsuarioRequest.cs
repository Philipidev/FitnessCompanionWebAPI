using FitnessCompanionWebAPI.Aplicacao.Responses.UsuariosResponses;
using MediatR;

namespace FitnessCompanionWebAPI.Aplicacao.Requests.UsuarioRequests
{
    public class CriarUsuarioRequest : IRequest<CriarUsuarioResponse>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Sobrenome { get; set; }
    }
}
