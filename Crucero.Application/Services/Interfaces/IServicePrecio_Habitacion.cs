using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Application.DTOs;

namespace Crucero.Application.Services.Interfaces
{
    public interface IServicePrecio_Habitacion
    {
        Task<ICollection<PrecioHabitacionesDTO>> ListAsync();
        Task<PrecioHabitacionesDTO> FindByIdAsync(int id);
    }
}
