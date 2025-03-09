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
    public class RepositoryBarco_Habitacion : IRepositoryBarco_Habitacion
    {
        private readonly WaddelsContext _context;

        public RepositoryBarco_Habitacion(WaddelsContext context)
        {
            _context = context;
        }

        public Task<BarcoHabitacion> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<BarcoHabitacion>> ListAsync()
        {
            //Select * from Autor
            var collection = await _context.Set<BarcoHabitacion>().ToListAsync();
            return collection;
        }
    }
}
