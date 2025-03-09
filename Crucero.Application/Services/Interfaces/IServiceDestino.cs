using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Application.DTOs;

namespace Crucero.Application.Services.Interfaces
{
    public interface IServiceDestino
    {
        Task<ICollection<DestinoDTO>> ListAsync();
        Task<DestinoDTO> FindByIdAsync(int id);
    }
}
