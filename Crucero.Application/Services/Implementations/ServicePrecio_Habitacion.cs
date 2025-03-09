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
    public class ServicePrecio_Habitacion : IServicePrecio_Habitacion
    {
        private readonly IRepositoryPrecio_Habitacion _repository;
        private readonly IMapper _mapper;

        public ServicePrecio_Habitacion(IRepositoryPrecio_Habitacion repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PrecioHabitacionesDTO> FindByIdAsync(int id)
        {
            var @object = await _repository.FindByIdAsync(id);
            var objectMapped = _mapper.Map<PrecioHabitacionesDTO>(@object);
            return objectMapped;

        }
        public async Task<ICollection<PrecioHabitacionesDTO>> ListAsync()
        {
            //Obtener datos del repositorio
            var list = await _repository.ListAsync();
            // Map List<Autor> a ICollection<BodegaDTO>
            var collection = _mapper.Map<ICollection<PrecioHabitacionesDTO>>(list);
            // Return lista
            return collection;
        }
    }
}
