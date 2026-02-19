using Clasificacions.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.Application.DTO
{
    public class PeliculaSimpleDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sinopsis { get; set; }
        public string Imagen { get; set; }
        public int ClasificacionId { get; set; }
        public string ClasificacionName { get; set; }
        public int GeneroId { get; set; }
        public string GeneroName { get; set; }
        public TimeOnly Duracion { get; set; }
    }
    public class PeliculaDTO 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sinopsis { get; set; }
        public string ImagenURL { get; set; }
        public ClasificacionSimpleDTO Clasificacion { get; set; }
        public GeneroSimpleDTO Genero { get; set; }
        public TimeOnly Duracion { get; set; }
    }    

    public class PeliculaCreateDTO
    {
        public string Nombre { get; set; }
        public string Sinopsis { get; set; }
        public string ImagenURL { get; set; }
        public int ClasificacionID { get; set; }
        public int GeneroID { get; set; }
        public TimeOnly Duracion { get; set; }
    }

    public class PeliculaUpdateDTO : PeliculaCreateDTO
    {
        public int Id { get; set; }
    }
}
