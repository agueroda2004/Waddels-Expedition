﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Application.DTOs;

namespace Crucero.Application.Services.Interfaces
{
    public interface IServicePago
    {
        Task<ICollection<PagoDTO>> ListAsync();
        Task<PagoDTO> FindByIdAsync(int id);
    }
}
