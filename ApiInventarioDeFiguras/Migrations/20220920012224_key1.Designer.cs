// <auto-generated />
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
    [Migration("20220920012224_key1")]
    partial class key1
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
                    b.Property<long>("Numero_de_Serie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Numero_de_Serie"), 1L, 1);

                    b.Property<int>("FiguraId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ola")
                        .HasColumnType("int");

                    b.HasKey("Numero_de_Serie");

                    b.HasIndex("FiguraId");

                    b.ToTable("Waves");
                });

            modelBuilder.Entity("ApiInventarioDeFiguras.Entidades.Wave", b =>
                {
                    b.HasOne("ApiInventarioDeFiguras.Entidades.Figura", "Figura")
                        .WithMany("Numero_de_Serie")
                        .HasForeignKey("FiguraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Figura");
                });

            modelBuilder.Entity("ApiInventarioDeFiguras.Entidades.Figura", b =>
                {
                    b.Navigation("Numero_de_Serie");
                });
#pragma warning restore 612, 618
        }
    }
}
