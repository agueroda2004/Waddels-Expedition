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
    public class RepositoryHabitacion : IRepositoryHabitacion
    {
        private readonly WaddelsContext _context;

        public RepositoryHabitacion(WaddelsContext context)
        {
            _context = context;
        }

        public async Task<Habitacion> FindByIdAsync(int id)
        {
            // Obtener una habitación por su ID desde la base de datos
            // Si no se encuentra, generará una excepción con FirstAsync()

            var habitacion = await _context.Set<Habitacion>()
                .Where(x => x.Id == id) // Filtrar por el ID de la habitación
                .AsNoTracking() // Mejora el rendimiento si solo se necesita leer los datos
                .FirstAsync(); // Obtener el primer resultado o lanzar una excepción si no hay coincidencias

            return habitacion; // Retornar la habitación encontrada
        }

        public async Task<ICollection<Habitacion>> ListAsync()
        {
            var collection = await _context.Set<Habitacion>().ToListAsync();
            return collection;
        }

        public async Task<ICollection<Habitacion>> FindByNameAsync(string nombre)
        {
            throw new NotImplementedException();
        }

    }
}
