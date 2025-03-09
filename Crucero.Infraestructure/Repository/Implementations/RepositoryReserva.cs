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
    public class RepositoryReserva : IRepositoryReserva
    {
        private readonly WaddelsContext _context;

        public RepositoryReserva(WaddelsContext context)
        {
            _context = context;
        }

        public async Task<Reserva> FindByIdAsync(int id)
        {
            // Obtener la reserva con la fecha de crucero relacionada
            var reserva = await _context.Set<Reserva>()
                .Where(r => r.Id == id)
                .Include(r => r.FechasCrucero)
                    .ThenInclude(f => f.Crucero)
                        .ThenInclude(b => b.Itinerario)
                            .ThenInclude(k => k.Puerto)
                .Include(BK => BK.ReservaDetalle)
                    .ThenInclude(fK => fK.Habitacion)
                        .ThenInclude(fK => fK.PrecioHabitaciones)
                .Include(lk => lk.ReservaComplemento)
                    .ThenInclude(d => d.Complemento)
                .Include(r => r.Estado)
                .AsNoTracking()
                .FirstAsync();


            return reserva;
        }


        public async Task<ICollection<Reserva>> ListAsync()
        {
            //Select * from Autor
            //Vamos a traernos id Reservacion, fecha Inicio, total, estado
            
            var collection = await _context.Set<Reserva>()
                .Include(r => r.Estado)
                .Include(r => r.FechasCrucero)
                    .ThenInclude(f => f.Crucero)
                 
                    
                .AsNoTracking()
                .ToListAsync();
            return collection;
        }
    }
}
