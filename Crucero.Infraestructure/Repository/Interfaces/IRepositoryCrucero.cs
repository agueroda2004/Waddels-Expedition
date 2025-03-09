using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Models;

namespace Crucero.Infraestructure.Repository.Interfaces
{
    public interface IRepositoryCrucero
    {
        Task<ICollection<Crucero.Infraestructure.Models.Crucero>> ListAsync();
        Task<Crucero.Infraestructure.Models.Crucero> FindByIdAsync(int id);

        Task<int> AddAsync(Crucero.Infraestructure.Models.Crucero entity);
    }
}
