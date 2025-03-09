﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Models;

namespace Crucero.Infraestructure.Repository.Interfaces
{
    public interface IRepositoryItinerario
    {
        Task<ICollection<Itinerario>> ListAsync();
        Task<Itinerario> FindByIdAsync(int id);
    }
}
