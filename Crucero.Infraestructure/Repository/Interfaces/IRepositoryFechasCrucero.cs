using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Models;

namespace Crucero.Infraestructure.Repository.Interfaces
{
    public interface IRepositoryFechasCrucero
    {
        Task<ICollection<FechasCrucero>> ListAsync();
        Task<FechasCrucero> FindByIdAsync(int id);
    }
}
