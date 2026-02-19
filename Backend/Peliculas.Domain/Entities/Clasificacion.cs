using Peliculas.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Domain.Entities
{
    public class Clasificacion : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Siglas { get; set; }

        [Required]
        [MinLength(5)]
        public string Nombre { get; set; }

        [Required]
        [MinLength(10)]
        public string Descripcion { get; set; }

        // Relacion con Pelicula
        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
    }
}
