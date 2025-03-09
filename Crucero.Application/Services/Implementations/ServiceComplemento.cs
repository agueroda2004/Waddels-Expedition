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
    public class ServiceComplemento : IServiceComplemento
    {
        private readonly IRepositoryComplemento _repository;
        private readonly IMapper _mapper;

        public ServiceComplemento(IRepositoryComplemento repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ComplementoDTO> FindByIdAsync(int id)
        {
            var @object = await _repository.FindByIdAsync(id);
            var objectMapped = _mapper.Map<ComplementoDTO>(@object);
            return objectMapped;

        }
        public async Task<ICollection<ComplementoDTO>> ListAsync()
        {
            //Obtener datos del repositorio
            var list = await _repository.ListAsync();
            // Map List<Autor> a ICollection<BodegaDTO>
            var collection = _mapper.Map<ICollection<ComplementoDTO>>(list);
            // Return lista
            return collection;
        }
    }
}
