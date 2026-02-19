using Microsoft.EntityFrameworkCore;
using Peliculas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.Infraestructure.Context
{
    public class PeliContext : DbContext
    {
        public PeliContext()
        {
            
        }

        public PeliContext(DbContextOptions<PeliContext> options) : base(options)
        {

        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Clasificacion> Clasificaciones { get; set; }
    }
}
