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
    public class RepositoryPago : IRepositoryPago
    {
        private readonly WaddelsContext _context;

        public RepositoryPago(WaddelsContext context)
        {
            _context = context;
        }

        public Task<Pago> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<Pago>> ListAsync()
        {
            //Select * from Autor
            var collection = await _context.Set<Pago>().ToListAsync();
            return collection;
        }
    }
}
