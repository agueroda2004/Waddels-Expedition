using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Models;

namespace Crucero.Infraestructure.Repository.Interfaces
{
    public interface IRepositoryEstadoReserva
    {
        Task<ICollection<EstadoReserva>> ListAsync();
        Task<EstadoReserva> FindByIdAsync(int id);
    }
}
