using AutoMapper;
using FitnessCompanionWebAPI.Aplicacao.Dtos.AtividadeDtos;
using FitnessCompanionWebAPI.Aplicacao.Dtos.TreinoDtos;
using FitnessCompanionWebAPI.Aplicacao.Dtos.UsuarioDtos;
using FitnessCompanionWebAPI.Dominio.Entidades;

namespace FitnessCompanionWebAPI.Aplicacao.Mapper
{
    public class AddMappers : Profile
    {
        public AddMappers()
        {
            CreateMap<Usuario, UsuarioDto>();
            //.ForMember(pts => pts.AtividadesPraticantes, opt => opt.MapFrom(ps => ps.AtividadesPraticantes));

            CreateMap<Treino, TreinoDto>();
            CreateMap<Atividade, AtividadeDto>();
        }
    }
}
