using Peliculas.Domain.Entities;
using Peliculas.Domain.Interfaces.Repositories;
using Peliculas.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.Infraestructure.Repositories
{
    public class ClasificacionRepository : BaseRepository<Clasificacion>, IClasificacionRepository
    {
        public ClasificacionRepository(PeliContext context) : base(context) { }
    }
}
