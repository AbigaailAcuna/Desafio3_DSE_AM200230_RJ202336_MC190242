using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Desafio3.Models
{
    public class Preparacion
    {
        [Key]
        public int Id { get; set; }

        [MinLength(10, ErrorMessage = "La descripción debe tener al menos 10 caracteres.")]
        [Required(ErrorMessage = "La descripción de los pasos es requerida.")]
        public string DescripcionPaso { get; set; }
        public int OrdenPaso { get; set; }

        [ForeignKey("RecetaID")]
        public int RecetaID { get; set; }
        public Receta Recetas { get; set; }
    }
}
