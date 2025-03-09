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
    public class RepositoryReserva_Detalle : IRepositoryReserva_Detalle
    {
        private readonly WaddelsContext _context;

        public RepositoryReserva_Detalle(WaddelsContext context)
        {
            _context = context;
        }

        public Task<ReservaDetalle> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<ReservaDetalle>> ListAsync()
        {
            //Select * from Autor
            var collection = await _context.Set<ReservaDetalle>().ToListAsync();
            return collection;
        }
    }
}
