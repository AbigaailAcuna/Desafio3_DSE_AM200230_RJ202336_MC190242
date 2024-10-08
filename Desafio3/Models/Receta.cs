using System.ComponentModel.DataAnnotations;

namespace Desafio3.Models
{
    public class Receta
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required(ErrorMessage = "El nombre de la receta es requerido")]
        public string NombreReceta { get; set; }
        public string DescripcionReceta { get; set; }
        public string TiempoPreparacion { get; set; }

      //  public ICollection<Ingrediente> Ingredientes { get; set; }
   //     public ICollection<Preparacion> Preparaciones { get; set; }
    }
}
