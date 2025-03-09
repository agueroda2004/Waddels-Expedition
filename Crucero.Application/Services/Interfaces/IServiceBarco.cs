﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Application.DTOs;

namespace Crucero.Application.Services.Interfaces
{
    public interface IServiceBarco
    {
        Task<ICollection<BarcoDTO>> ListAsync();
        Task<BarcoDTO> FindByIdAsync(int id);
    }
}
