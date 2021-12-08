using FitnessCompanionWebAPI.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Sobrenome).HasMaxLength(50);
            builder.Property(x => x.Senha).HasMaxLength(255);
            builder.Property(x => x.Avatar);
            builder.Property(x => x.Avaliacao).HasDefaultValue(0);
            builder.Property(x => x.Sobre);

            builder.HasMany(x => x.AtividadesPraticantes).WithOne();
            builder.HasMany(x => x.Treinos).WithOne();

            builder.Property(x => x.DataAtualizacao);
            builder.Property(x => x.DataCriacao).ValueGeneratedOnAdd()
                .HasDefaultValueSql("getdate()");
            builder.Property(x => x.DataExclusao);

        }
    }
}
