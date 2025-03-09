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
    public class RepositoryBarco : IRepositoryBarco
    {
        private readonly WaddelsContext _context;

        public RepositoryBarco(WaddelsContext context)
        {
            _context = context;
        }

        public async Task<Barco> FindByIdAsync(int id)
        {

            var barco = await _context.Set<Barco>()
                .Include(f => f.BarcoHabitacion)
                    .ThenInclude(bh => bh.IdHabitacionNavigation)
                .Where(x => x.Id == id) 
                .FirstAsync(); 

            return barco;
        }

        public async Task<ICollection<Barco>> ListAsync()
        {

            var barcos = await _context.Set<Barco>()
                .Include(b => b.BarcoHabitacion) 
                .ToListAsync();

            return barcos;

  
         

        }

    }
}
