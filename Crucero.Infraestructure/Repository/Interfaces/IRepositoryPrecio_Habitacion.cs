using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Models;

namespace Crucero.Infraestructure.Repository.Interfaces
{
    public interface IRepositoryPrecio_Habitacion
    {
        Task<ICollection<PrecioHabitaciones>> ListAsync();
        Task<PrecioHabitaciones> FindByIdAsync(int id);
    }
}
