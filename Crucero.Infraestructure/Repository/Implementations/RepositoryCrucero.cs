using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Crucero.Infraestructure.Data;
using Crucero.Infraestructure.Models;
using Crucero.Infraestructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crucero.Infraestructure.Repository.Implementations
{
    public class RepositoryCrucero : IRepositoryCrucero
    {
        private readonly WaddelsContext _context;

        public RepositoryCrucero(WaddelsContext context)
        {
            _context = context;
        }

        public async Task<Crucero.Infraestructure.Models.Crucero> FindByIdAsync(int id)
        {
            var crucero = await _context.Set<Crucero.Infraestructure.Models.Crucero>()
                .Where(x => x.Id == id) // Filtrar por el ID de la habitación
                .Include(c => c.Barco)
                .Include(b => b.Itinerario)
                    .ThenInclude(i => i.Puerto)
                        .ThenInclude(p => p.Destino)
                .Include(fc => fc.FechasCrucero)
                    .ThenInclude(a => a.PrecioHabitaciones)
                        .ThenInclude(f => f.Habitacion)
                .AsNoTracking()
                .FirstAsync();

            return crucero;
        }
        public async Task<ICollection<Crucero.Infraestructure.Models.Crucero>> ListAsync()
        {
            //Select * from Crucero
            var collection = await _context.Set<Crucero.Infraestructure.Models.Crucero>().ToListAsync();
            return collection;
        }

        public async Task<int> AddAsync(Crucero.Infraestructure.Models.Crucero entity)
        {
            await _context.Set<Crucero.Infraestructure.Models.Crucero>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
    }
}
