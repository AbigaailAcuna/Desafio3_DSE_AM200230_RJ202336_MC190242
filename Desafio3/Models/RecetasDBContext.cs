using Microsoft.EntityFrameworkCore;

namespace Desafio3.Models
{
    public class RecetasDBContext : DbContext
    {
        public RecetasDBContext(DbContextOptions<RecetasDBContext> options)
            : base(options) { }

        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Preparacion> Preparaciones { get; set; }
        public DbSet<Receta> Recetas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seeds receta
            modelBuilder.Entity<Receta>().HasData(
                new Receta
                {
                    Id = 1,
                    NombreReceta = "Ensalada César",
                    DescripcionReceta = "Ensalada clásica con pollo, lechuga y aderezo césar.",
                    TiempoPreparacion = "20 minutos"
                },
                 new Receta
                 {
                     Id = 2,
                     NombreReceta = "Pasta Carbonara",
                     DescripcionReceta = "Pasta con salsa de crema, huevo y queso parmesano.",
                     TiempoPreparacion = "30 minutos"
                 },
                  new Receta
                  {
                      Id = 3,
                      NombreReceta = "Sopa de Tomate",
                      DescripcionReceta = "Sopa ligera de tomate con albahaca.",
                      TiempoPreparacion = "40 minutos"
                  });

            //seeds ingrediente
            modelBuilder.Entity<Ingrediente>().HasData(
                new Ingrediente
                {
                    Id = 1,
                    NombreIngrediente = "Lechuga Romana",
                    CantidadIngrediente = 1 ,
                    UnidadMedida = "Unidad",
                    RecetaID = 1
                },
                 new Ingrediente
                 {
                     Id = 2,
                     NombreIngrediente = "Pollo a la parrilla",
                     CantidadIngrediente = 200,
                     UnidadMedida = "Gramos",
                     RecetaID = 1
                 },
                  new Ingrediente
                  {
                      Id = 3,
                      NombreIngrediente = "Aderezo césar",
                      CantidadIngrediente = 50,
                      UnidadMedida = "Mililitros",
                      RecetaID = 1
                  },
                  new Ingrediente
                  {
                      Id = 4,
                      NombreIngrediente = "Pasta espagueti",
                      CantidadIngrediente = 250,
                      UnidadMedida = "Gramos",
                      RecetaID = 2
                  },
                 new Ingrediente
                 {
                     Id = 5,
                     NombreIngrediente = "Crema de leche",
                     CantidadIngrediente = 100,
                     UnidadMedida = "Mililitros",
                     RecetaID = 2
                 },
                  new Ingrediente
                  {
                      Id = 6,
                      NombreIngrediente = "Huevo",
                      CantidadIngrediente = 1,
                      UnidadMedida = "Unidad",
                      RecetaID = 2
                  },
                  new Ingrediente
                  {
                      Id = 7,
                      NombreIngrediente = "Queso Parmesano",
                      CantidadIngrediente = 50,
                      UnidadMedida = "Gramos",
                      RecetaID = 2
                  },
                   new Ingrediente
                   {
                       Id = 8,
                       NombreIngrediente = "Tomates Frescos",
                       CantidadIngrediente = 500,
                       UnidadMedida = "Gramos",
                       RecetaID = 3
                   },
                    new Ingrediente
                    {
                        Id = 9,
                        NombreIngrediente = "Albahaca",
                        CantidadIngrediente = 5,
                        UnidadMedida = "Hojas",
                        RecetaID = 3
                    });

            //seeds preparación
            modelBuilder.Entity<Preparacion>().HasData(
                new Preparacion
                {
                    Id = 1,
                    DescripcionPaso = "Lavar la lechuga romana y cortarla en trozos",
                    OrdenPaso = 1,
                    RecetaID = 1
                },
                 new Preparacion
                 {
                     Id = 2,
                     DescripcionPaso = "Asar el pollo a la parrilla y cortarlo en tiras.",
                     OrdenPaso = 2,
                     RecetaID = 1

                 },
                  new Preparacion
                  {
                      Id = 3,
                      DescripcionPaso = "Mezclar la lechuga, el pollo y el aderezo césar.",
                      OrdenPaso = 3,
                      RecetaID = 1

                  },
                  new Preparacion
                  {
                      Id = 4,
                      DescripcionPaso = "Cocinar la pasta en agua hirviendo con sal.",
                      OrdenPaso = 1,
                      RecetaID = 2

                  }, new Preparacion
                  {
                      Id = 5,
                      DescripcionPaso = "Mezclar el huevo, a crema y el queso parmesano.",
                      OrdenPaso = 2,
                      RecetaID = 2

                  }, new Preparacion
                  {
                      Id = 6,
                      DescripcionPaso = "Añadir la mezcla a la pasta caliente.",
                      OrdenPaso = 3,
                      RecetaID = 2

                  }, new Preparacion
                  {
                      Id = 7,
                      DescripcionPaso = "Cortar los tomates y hervirlos hasta que se ablanden.",
                      OrdenPaso = 1,
                      RecetaID = 3

                  },
                  new Preparacion
                  {
                      Id = 8,
                      DescripcionPaso = "Licuar los tomates y agregar la albahaca.",
                      OrdenPaso = 2,
                      RecetaID = 3

                  }, new Preparacion
                  {
                      Id = 9,
                      DescripcionPaso = "Cocinar por 10 minutos más y servir caliente.",
                      OrdenPaso = 3,
                      RecetaID = 3

                  });
        }

    }
}
