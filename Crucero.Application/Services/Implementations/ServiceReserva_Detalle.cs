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
    public class ServiceReserva_Detalle : IServiceReserva_Detalle
    {
        private readonly IRepositoryReserva_Detalle _repository;
        private readonly IMapper _mapper;

        public ServiceReserva_Detalle(IRepositoryReserva_Detalle repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ReservaDetalleDTO> FindByIdAsync(int id)
        {
            var @object = await _repository.FindByIdAsync(id);
            var objectMapped = _mapper.Map<ReservaDetalleDTO>(@object);
            return objectMapped;

        }
        public async Task<ICollection<ReservaDetalleDTO>> ListAsync()
        {
            //Obtener datos del repositorio
            var list = await _repository.ListAsync();
            // Map List<Autor> a ICollection<BodegaDTO>
            var collection = _mapper.Map<ICollection<ReservaDetalleDTO>>(list);
            // Return lista
            return collection;
        }
    }
}
