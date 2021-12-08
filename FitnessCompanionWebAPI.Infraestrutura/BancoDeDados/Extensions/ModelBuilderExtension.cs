using FitnessCompanionWebAPI.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                    new Usuario()
                    {
                        Id = Guid.NewGuid(),
                        Email = "philipi.altoe@gmail.com",
                        Nome = "Philipi",
                        Sobrenome = "Carvalho",
                        Senha = "123",
                        DataCriacao = DateTime.Now,
                    }
                );

            return modelBuilder;
        }
    }
}
