using System.ComponentModel.DataAnnotations;

namespace CrudAplicacion.Models
{
    public class PeliculaModel
    {
        public int IdPelicula { get; set; }

        [Required(ErrorMessage = "Debe ingresa una pelicula porque es requerida para este campo")]
        public string? Pelicula { get; set; }
        [Required(ErrorMessage = "Debe ingresa una categoria porque es requerida para este campo")]
        public string? Categoria { get; set; }
        [Required(ErrorMessage = "Debe ingresa un actor porque es requerido para este campo")]
        public string? Actor { get; set; }
        
    }
}
