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
    public class ServiceBarco_Habitacion : IServiceBarco_Habitacion
    {
        private readonly IRepositoryBarco_Habitacion _repository;
        private readonly IMapper _mapper;

        public ServiceBarco_Habitacion(IRepositoryBarco_Habitacion repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<BarcoHabitacionDTO> FindByIdAsync(int id)
        {
            var @object = await _repository.FindByIdAsync(id);
            var objectMapped = _mapper.Map<BarcoHabitacionDTO>(@object);
            return objectMapped;

        }
        public async Task<ICollection<BarcoHabitacionDTO>> ListAsync()
        {
            //Obtener datos del repositorio
            var list = await _repository.ListAsync();
            // Map List<Autor> a ICollection<BodegaDTO>
            var collection = _mapper.Map<ICollection<BarcoHabitacionDTO>>(list);
            // Return lista
            return collection;
        }
    }
}
