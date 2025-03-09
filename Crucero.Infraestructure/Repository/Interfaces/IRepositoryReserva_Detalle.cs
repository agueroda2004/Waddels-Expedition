using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Models;

namespace Crucero.Infraestructure.Repository.Interfaces
{
    public interface IRepositoryReserva_Detalle
    {
        Task<ICollection<ReservaDetalle>> ListAsync();
        Task<ReservaDetalle> FindByIdAsync(int id);
    }
}
