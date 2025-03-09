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
    public class RepositoryFechasCrucero : IRepositoryFechasCrucero
    {
        private readonly WaddelsContext _context;

        public RepositoryFechasCrucero(WaddelsContext context)
        {
            _context = context;
        }

        public Task<FechasCrucero> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<FechasCrucero>> ListAsync()
        {
            //Select * from Autor
            var collection = await _context.Set<FechasCrucero>().ToListAsync();
            return collection;
        }
    }
}
