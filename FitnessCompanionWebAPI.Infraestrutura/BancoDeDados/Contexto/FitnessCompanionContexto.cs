using FitnessCompanionWebAPI.Dominio.Entidades;
using FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Extensions;
using FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Mapeamento;
using Microsoft.EntityFrameworkCore;

namespace FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Contexto
{
    public class FitnessCompanionContexto : DbContext
    {
        public FitnessCompanionContexto(DbContextOptions<FitnessCompanionContexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Treino> Treino { get; set; }
        public DbSet<Atividade> Atividade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TreinoMap());
            modelBuilder.ApplyConfiguration(new AtividadeMap());
            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
