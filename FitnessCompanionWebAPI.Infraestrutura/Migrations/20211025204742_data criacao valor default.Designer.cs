﻿// <auto-generated />
using System;
using FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FitnessCompanionWebAPI.Infraestrutura.Migrations
{
    [DbContext(typeof(FitnessCompanionContexto))]
    [Migration("20211025204742_data criacao valor default")]
    partial class datacriacaovalordefault
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitnessCompanionWebAPI.Dominio.Entidades.Atividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Atividade");
                });

            modelBuilder.Entity("FitnessCompanionWebAPI.Dominio.Entidades.Treino", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AtividadeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("NomeLocal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AtividadeId");

                    b.ToTable("Treino");
                });

            modelBuilder.Entity("FitnessCompanionWebAPI.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAtualizacao")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Senha")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sobrenome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3eba1da2-8c67-4f1f-8634-885811557b7b"),
                            DataCriacao = new DateTime(2021, 10, 25, 17, 47, 41, 637, DateTimeKind.Local).AddTicks(4582),
                            Email = "philipi.altoe@gmail.com",
                            Nome = "Philipi",
                            Senha = "123",
                            Sobrenome = "Carvalho"
                        });
                });

            modelBuilder.Entity("FitnessCompanionWebAPI.Dominio.Entidades.Treino", b =>
                {
                    b.HasOne("FitnessCompanionWebAPI.Dominio.Entidades.Atividade", "Atividade")
                        .WithMany()
                        .HasForeignKey("AtividadeId");

                    b.Navigation("Atividade");
                });
#pragma warning restore 612, 618
        }
    }
}