using System;

namespace FitnessCompanionWebAPI.Dominio.Entidades
{
    public class Treino
    {
        public Guid Id { get; set; }
        public string NomeLocal { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Data { get; set; }
        public int Duracao { get; set; }
        public Atividade Atividade { get; set; }
    }
}
