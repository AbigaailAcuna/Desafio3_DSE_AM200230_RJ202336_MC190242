﻿// <auto-generated />
using Desafio3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Desafio3.Migrations
{
    [DbContext(typeof(RecetasDBContext))]
    [Migration("20241008043636_Migración Inicial")]
    partial class MigraciónInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Desafio3.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantidadIngrediente")
                        .HasColumnType("int");

                    b.Property<string>("NombreIngrediente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RecetaID")
                        .HasColumnType("int");

                    b.Property<string>("UnidadMedida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecetaID");

                    b.ToTable("Ingredientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CantidadIngrediente = 1,
                            NombreIngrediente = "Lechuga Romana",
                            RecetaID = 1,
                            UnidadMedida = "Unidad"
                        },
                        new
                        {
                            Id = 2,
                            CantidadIngrediente = 200,
                            NombreIngrediente = "Pollo a la parrilla",
                            RecetaID = 1,
                            UnidadMedida = "Gramos"
                        },
                        new
                        {
                            Id = 3,
                            CantidadIngrediente = 50,
                            NombreIngrediente = "Aderezo césar",
                            RecetaID = 1,
                            UnidadMedida = "Mililitros"
                        },
                        new
                        {
                            Id = 4,
                            CantidadIngrediente = 250,
                            NombreIngrediente = "Pasta espagueti",
                            RecetaID = 2,
                            UnidadMedida = "Gramos"
                        },
                        new
                        {
                            Id = 5,
                            CantidadIngrediente = 100,
                            NombreIngrediente = "Crema de leche",
                            RecetaID = 2,
                            UnidadMedida = "Mililitros"
                        },
                        new
                        {
                            Id = 6,
                            CantidadIngrediente = 1,
                            NombreIngrediente = "Huevo",
                            RecetaID = 2,
                            UnidadMedida = "Unidad"
                        },
                        new
                        {
                            Id = 7,
                            CantidadIngrediente = 50,
                            NombreIngrediente = "Queso Parmesano",
                            RecetaID = 2,
                            UnidadMedida = "Gramos"
                        },
                        new
                        {
                            Id = 8,
                            CantidadIngrediente = 500,
                            NombreIngrediente = "Tomates Frescos",
                            RecetaID = 3,
                            UnidadMedida = "Gramos"
                        },
                        new
                        {
                            Id = 9,
                            CantidadIngrediente = 5,
                            NombreIngrediente = "Albahaca",
                            RecetaID = 3,
                            UnidadMedida = "Hojas"
                        });
                });

            modelBuilder.Entity("Desafio3.Models.Preparacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescripcionPaso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdenPaso")
                        .HasColumnType("int");

                    b.Property<int>("RecetaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecetaID");

                    b.ToTable("Preparaciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DescripcionPaso = "Lavar la lechuga romana y cortarla en trozos",
                            OrdenPaso = 1,
                            RecetaID = 1
                        },
                        new
                        {
                            Id = 2,
                            DescripcionPaso = "Asar el pollo a la parrilla y cortarlo en tiras.",
                            OrdenPaso = 2,
                            RecetaID = 1
                        },
                        new
                        {
                            Id = 3,
                            DescripcionPaso = "Mezclar la lechuga, el pollo y el aderezo césar.",
                            OrdenPaso = 3,
                            RecetaID = 1
                        },
                        new
                        {
                            Id = 4,
                            DescripcionPaso = "Cocinar la pasta en agua hirviendo con sal.",
                            OrdenPaso = 1,
                            RecetaID = 2
                        },
                        new
                        {
                            Id = 5,
                            DescripcionPaso = "Mezclar el huevo, a crema y el queso parmesano.",
                            OrdenPaso = 2,
                            RecetaID = 2
                        },
                        new
                        {
                            Id = 6,
                            DescripcionPaso = "Añadir la mezcla a la pasta caliente.",
                            OrdenPaso = 3,
                            RecetaID = 2
                        },
                        new
                        {
                            Id = 7,
                            DescripcionPaso = "Cortar los tomates y hervirlos hasta que se ablanden.",
                            OrdenPaso = 1,
                            RecetaID = 3
                        },
                        new
                        {
                            Id = 8,
                            DescripcionPaso = "Licuar los tomates y agregar la albahaca.",
                            OrdenPaso = 2,
                            RecetaID = 3
                        },
                        new
                        {
                            Id = 9,
                            DescripcionPaso = "Cocinar por 10 minutos más y servir caliente.",
                            OrdenPaso = 3,
                            RecetaID = 3
                        });
                });

            modelBuilder.Entity("Desafio3.Models.Receta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescripcionReceta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreReceta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TiempoPreparacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recetas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DescripcionReceta = "Ensalada clásica con pollo, lechuga y aderezo césar.",
                            NombreReceta = "Ensalada César",
                            TiempoPreparacion = "20 minutos"
                        },
                        new
                        {
                            Id = 2,
                            DescripcionReceta = "Pasta con salsa de crema, huevo y queso parmesano.",
                            NombreReceta = "Pasta Carbonara",
                            TiempoPreparacion = "30 minutos"
                        },
                        new
                        {
                            Id = 3,
                            DescripcionReceta = "Sopa ligera de tomate con albahaca.",
                            NombreReceta = "Sopa de Tomate",
                            TiempoPreparacion = "40 minutos"
                        });
                });

            modelBuilder.Entity("Desafio3.Models.Ingrediente", b =>
                {
                    b.HasOne("Desafio3.Models.Receta", "Recetas")
                        .WithMany("Ingredientes")
                        .HasForeignKey("RecetaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recetas");
                });

            modelBuilder.Entity("Desafio3.Models.Preparacion", b =>
                {
                    b.HasOne("Desafio3.Models.Receta", "Recetas")
                        .WithMany("Preparaciones")
                        .HasForeignKey("RecetaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recetas");
                });

            modelBuilder.Entity("Desafio3.Models.Receta", b =>
                {
                    b.Navigation("Ingredientes");

                    b.Navigation("Preparaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
