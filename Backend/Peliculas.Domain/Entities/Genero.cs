using Peliculas.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Domain.Entities
{
    [Table("Generos")]
    public class Genero : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(15)]
        public string Descripcion { get; set; }

        // Relacion con Pelicula
        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
    }
}
