using Peliculas.Application.DTO;
using Peliculas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clasificacions.Application.DTO
{
    public class ClasificacionSimpleDTO
    {
        public int Id { get; set; }
        public string Siglas { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantidadPeliculas { get; set; }
    }
    public class ClasificacionDTO 
    {
        public int Id { get; set; }
        public string Siglas { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<PeliculaSimpleDTO> CantidadPeliculas { get; set; }
    }
    public class ClasificacionCreateDTO
    {
        public string Siglas { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class ClasificacionUpdateDTO : ClasificacionCreateDTO
    {
        public int Id { get; set; }
    }
}
