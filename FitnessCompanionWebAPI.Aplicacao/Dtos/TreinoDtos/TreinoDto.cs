using FitnessCompanionWebAPI.Aplicacao.Dtos.AtividadeDtos;
using System;

namespace FitnessCompanionWebAPI.Aplicacao.Dtos.TreinoDtos
{
    public class TreinoDto
    {
        public Guid Id { get; set; }
        public string NomeLocal { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Data { get; set; }
        public int Duracao { get; set; }
        public AtividadeDto Atividade { get; set; }
    }
}
