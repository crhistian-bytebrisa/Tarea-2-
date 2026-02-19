using Peliculas.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Domain.Entities
{
    [Table("Peliculas")]
    public class Pelicula : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(10)]
        public string Sinopsis { get; set; }

        [Required]
        public string Imagen { get; set; }

        [Required]
        public int ClasificacionId { get; set; }
        public Clasificacion Clasificacion { get; set; }

        [Required]
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }   
        
        [Required]
        public TimeOnly Duracion { get; set; }
    }
}
