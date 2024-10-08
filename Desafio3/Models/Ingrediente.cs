using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio3.Models
{
    public class Ingrediente
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "El nombre del ingrediente es requerido")]
        public string NombreIngrediente { get; set; }
        public int CantidadIngrediente { get; set; }
        public string UnidadMedida { get; set; }

        [ForeignKey("RecetaID")]
        public int RecetaID { get; set; }

        public Receta Recetas { get; set; }

    }
}
