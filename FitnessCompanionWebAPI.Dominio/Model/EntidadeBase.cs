using System;

namespace FitnessCompanionWebAPI.Dominio.Model
{
    public class EntidadeBase
    {
        public DateTime DataCriacao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
