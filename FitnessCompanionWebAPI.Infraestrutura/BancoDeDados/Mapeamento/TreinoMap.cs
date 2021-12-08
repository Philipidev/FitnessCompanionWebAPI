using FitnessCompanionWebAPI.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Mapeamento
{
    public class TreinoMap : IEntityTypeConfiguration<Treino>
    {
        public void Configure(EntityTypeBuilder<Treino> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.NomeLocal).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Latitude).HasMaxLength(50);
            builder.Property(x => x.Longitude).HasMaxLength(255);
            builder.Property(x => x.Data);
            builder.Property(x => x.Duracao).HasDefaultValue(0);

            builder.HasOne(x => x.Atividade);
        }
    }
}
