﻿// <auto-generated />
using System;
using Filmes.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Filmes.Data.Migrations
{
    [DbContext(typeof(FilmesContext))]
    [Migration("20200329145830_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Filmes.Shared.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Classificacao")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("DATE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Sinopse")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.HasKey("Id");

                    b.ToTable("TAB_FILME");
                });

            modelBuilder.Entity("Filmes.Shared.Models.FilmeGenero", b =>
                {
                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.HasKey("FilmeId", "GeneroId");

                    b.HasIndex("FilmeId");

                    b.HasIndex("GeneroId");

                    b.ToTable("TAB_FILME_GENERO");
                });

            modelBuilder.Entity("Filmes.Shared.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("TAB_GENERO");
                });

            modelBuilder.Entity("Filmes.Shared.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("TAB_USUARIO");
                });

            modelBuilder.Entity("Filmes.Shared.Models.FilmeGenero", b =>
                {
                    b.HasOne("Filmes.Shared.Models.Filme", "Filme")
                        .WithMany("FilmeGeneros")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Filmes.Shared.Models.Genero", "Genero")
                        .WithMany("FilmeGeneros")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}