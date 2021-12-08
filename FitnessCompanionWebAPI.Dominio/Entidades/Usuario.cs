using FitnessCompanionWebAPI.Dominio.Model;
using System;
using System.Collections.Generic;

namespace FitnessCompanionWebAPI.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        //[Key] ->  para configurar uma chave primario que nao se chame 'Id'
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Avatar { get; set; }
        public double Avaliacao { get; set; }
        public string Sobre { get; set; }
        public IEnumerable<Atividade> AtividadesPraticantes { get; set; }
        public IEnumerable<Treino> Treinos { get; set; }
    }
}
