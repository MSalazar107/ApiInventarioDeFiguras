﻿// <auto-generated />
using System;
using ApiInventarioDeFiguras;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiInventarioDeFiguras.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220928020223_upd")]
    partial class upd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiInventarioDeFiguras.Entidades.Figura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Franquicia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Figuras");
                });

            modelBuilder.Entity("ApiInventarioDeFiguras.Entidades.Wave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("FiguraId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ola")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FiguraId");

                    b.ToTable("Waves");
                });

            modelBuilder.Entity("ApiInventarioDeFiguras.Entidades.Wave", b =>
                {
                    b.HasOne("ApiInventarioDeFiguras.Entidades.Figura", null)
                        .WithMany("Numero_de_Serie")
                        .HasForeignKey("FiguraId");
                });

            modelBuilder.Entity("ApiInventarioDeFiguras.Entidades.Figura", b =>
                {
                    b.Navigation("Numero_de_Serie");
                });
#pragma warning restore 612, 618
        }
    }
}
