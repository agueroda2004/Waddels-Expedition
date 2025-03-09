using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Crucero.Application.DTOs;
using Crucero.Application.Services.Interfaces;
using Crucero.Infraestructure.Models;
using Crucero.Infraestructure.Repository.Interfaces;

namespace Crucero.Application.Services.Implementations
{
    public class ServiceCrucero : IServiceCrucero
    {
        private readonly IRepositoryCrucero _repository;
        private readonly IMapper _mapper;

        public ServiceCrucero(IRepositoryCrucero repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CruceroDTO> FindByIdAsync(int id)
        {
            var crucero = await _repository.FindByIdAsync(id);
            var objectMapped = _mapper.Map<CruceroDTO>(crucero);
            return objectMapped;
        }

        public async Task<ICollection<CruceroDTO>> ListAsync()
        {
            //Obtener datos del repositorio
            var list = await _repository.ListAsync();
            var collection = _mapper.Map<ICollection<CruceroDTO>>(list);
            // Return lista
            return collection;
        }

        public async Task<int> AddAsync(CruceroDTO dto)
        {
            // Map LibroDTO to Libro
            var objectMapped = _mapper.Map<Crucero.Infraestructure.Models.Crucero>(dto);

            // Return
            return await _repository.AddAsync(objectMapped);
        }
    }
}
