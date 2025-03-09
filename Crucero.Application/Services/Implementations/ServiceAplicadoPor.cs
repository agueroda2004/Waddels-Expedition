using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Crucero.Application.DTOs;
using Crucero.Application.Services.Interfaces;
using Crucero.Infraestructure.Repository.Interfaces;

namespace Crucero.Application.Services.Implementations
{
    public class ServiceAplicadoPor : IServiceAplicadoPor
    {
        private readonly IRepositoryAplicadoPor _repository;
        private readonly IMapper _mapper;

        public ServiceAplicadoPor(IRepositoryAplicadoPor repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<AplicadoPorDTO> FindByIdAsync(int id)
        {
            var @object = await _repository.FindByIdAsync(id);
            var objectMapped = _mapper.Map<AplicadoPorDTO>(@object);
            return objectMapped;

        }
        public async Task<ICollection<AplicadoPorDTO>> ListAsync()
        {
            //Obtener datos del repositorio
            var list = await _repository.ListAsync();
            // Map List<Autor> a ICollection<BodegaDTO>
            var collection = _mapper.Map<ICollection<AplicadoPorDTO>>(list);
            // Return lista
            return collection;
        }
    }
}
