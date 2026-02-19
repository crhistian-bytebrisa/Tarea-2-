using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.Application.DTO
{
    public class GeneroSimpleDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantidadPeliculas { get; set; }
    }

    public class GeneroDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<PeliculaSimpleDTO> Peliculas { get; set; }
    }

    public class GeneroCreateDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class GeneroUpdateDTO : GeneroCreateDTO
    {
        public int Id { get; set; }
    }
}
