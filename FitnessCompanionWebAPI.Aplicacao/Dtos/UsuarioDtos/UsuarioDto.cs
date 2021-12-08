using FitnessCompanionWebAPI.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace FitnessCompanionWebAPI.Aplicacao.Dtos.UsuarioDtos
{
    public class UsuarioDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        //public string Senha { get; set; }
        public string Avatar { get; set; }
        public double Avaliacao { get; set; }
        public string Sobre { get; set; }
        public IEnumerable<Atividade> AtividadesPraticantes { get; set; }
        public IEnumerable<Treino> Treinos { get; set; }
    }
}
