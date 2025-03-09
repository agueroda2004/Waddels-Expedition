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
    public class RepositoryEstadoReserva : IRepositoryEstadoReserva
    {
        private readonly WaddelsContext _context;

        public RepositoryEstadoReserva(WaddelsContext context)
        {
            _context = context;
        }

        public Task<EstadoReserva> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<EstadoReserva>> ListAsync()
        {
            //Select * from Autor
            var collection = await _context.Set<EstadoReserva>().ToListAsync();
            return collection;
        }
    }
}
