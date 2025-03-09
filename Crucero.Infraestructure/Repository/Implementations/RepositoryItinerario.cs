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
    public class RepositoryItinerario : IRepositoryItinerario
    {
        private readonly WaddelsContext _context;

        public RepositoryItinerario(WaddelsContext context)
        {
            _context = context;
        }

        public Task<Itinerario> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ICollection<Itinerario>> ListAsync()
        {
            //Select * from Autor
            var collection = await _context.Set<Itinerario>().ToListAsync();
            return collection;
        }
    }
}
