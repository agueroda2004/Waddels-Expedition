using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Data;
using Crucero.Infraestructure.Models;
using Crucero.Infraestructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crucero.Infraestructure.Repository.Implementations
{
    public class RepositoryPrecio_Habitacion : IRepositoryPrecio_Habitacion
    {
        private readonly WaddelsContext _context;

        public RepositoryPrecio_Habitacion(WaddelsContext context)
        {
            _context = context;
        }

        public Task<PrecioHabitaciones> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<PrecioHabitaciones>> ListAsync()
        {
            //Select * from Autor
            var collection = await _context.Set<PrecioHabitaciones>().ToListAsync();
            return collection;
        }
    }
}
