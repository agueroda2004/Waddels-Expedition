using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Application.DTOs;

namespace Crucero.Application.Services.Interfaces
{
    public interface IServiceOcupantes
    {
        Task<ICollection<OcupanteDTO>> ListAsync();
        Task<OcupanteDTO> FindByIdAsync(int id);
    }
}
