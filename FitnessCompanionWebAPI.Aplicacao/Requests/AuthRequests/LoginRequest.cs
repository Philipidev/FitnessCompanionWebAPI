using FitnessCompanionWebAPI.Aplicacao.Responses.LoginResponses;
using MediatR;

namespace FitnessCompanionWebAPI.Aplicacao.Requests.AuthRequests
{
    public class LoginRequest : IRequest<LoginResponse>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
