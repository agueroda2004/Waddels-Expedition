using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Application.DTOs;

namespace Crucero.Application.Services.Interfaces
{
    public interface IServiceItinerario
    {
        Task<ICollection<ItinerarioDTO>> ListAsync();
        Task<ItinerarioDTO> FindByIdAsync(int id);
    }
}
