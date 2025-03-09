using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Models;

namespace Crucero.Infraestructure.Repository.Interfaces
{
    public interface IRepositoryOcupantes
    {
        Task<ICollection<Ocupantes>> ListAsync();
        Task<Ocupantes> FindByIdAsync(int id);
    }
}
