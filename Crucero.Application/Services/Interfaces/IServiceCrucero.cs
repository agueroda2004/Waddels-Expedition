using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Application.DTOs;

namespace Crucero.Application.Services.Interfaces
{
    public interface IServiceCrucero
    {
        Task<ICollection<CruceroDTO>> ListAsync();
        Task<CruceroDTO> FindByIdAsync(int id);

        Task<int> AddAsync(CruceroDTO dto);
    }
}
