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
    public class RepositoryPuerto : IRepositoryPuerto
    {
        private readonly WaddelsContext _context;

        public RepositoryPuerto(WaddelsContext context)
        {
            _context = context;
        }

        public Task<Puerto> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<Puerto>> ListAsync()
        {
            //Select * from Autor
            var collection = await _context.Set<Puerto>().ToListAsync();
            return collection;
        }
    }
}
