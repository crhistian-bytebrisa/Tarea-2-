using Peliculas.Domain.Entities;
using Peliculas.Domain.Interfaces.Repositories;
using Peliculas.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.Infraestructure.Repositories
{
    public class GeneroRepository : BaseRepository<Genero>, IGeneroRepository
    {
        public GeneroRepository(PeliContext context) : base(context) { }
    }
}
