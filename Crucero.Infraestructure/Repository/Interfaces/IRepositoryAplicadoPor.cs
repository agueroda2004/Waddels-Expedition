using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Models;

namespace Crucero.Infraestructure.Repository.Interfaces
{
    public interface IRepositoryAplicadoPor
    {
        Task<ICollection<AplicadoPor>> ListAsync();
        Task<AplicadoPor> FindByIdAsync(int id);
    }
}
