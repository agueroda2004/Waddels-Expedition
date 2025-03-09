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
    public class ServiceNotificacion : IServiceNotificacion
    {
        private readonly IRepositoryNotificacion _repository;
        private readonly IMapper _mapper;

        public ServiceNotificacion(IRepositoryNotificacion repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<NotificacionDTO> FindByIdAsync(int id)
        {
            var @object = await _repository.FindByIdAsync(id);
            var objectMapped = _mapper.Map<NotificacionDTO>(@object);
            return objectMapped;

        }
        public async Task<ICollection<NotificacionDTO>> ListAsync()
        {
            //Obtener datos del repositorio
            var list = await _repository.ListAsync();
            // Map List<Autor> a ICollection<BodegaDTO>
            var collection = _mapper.Map<ICollection<NotificacionDTO>>(list);
            // Return lista
            return collection;
        }
    }
}
