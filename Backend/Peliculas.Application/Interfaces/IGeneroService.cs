using Peliculas.Application.DTO;
using Peliculas.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.Application.Interfaces
{
    public interface IGeneroService
    {
        public Task<GeneroDTO> GetByIdAsync();
        public Task<List<GeneroSimpleDTO>> GetAllAsync();
        public Task<GeneroDTO> AddAsync(GeneroCreateDTO dto);
        public Task<GeneroDTO> UpdateAsync(GeneroUpdateDTO dto, int Id);
        public Task DeleteByIdAsync(int Id);
    }
}
