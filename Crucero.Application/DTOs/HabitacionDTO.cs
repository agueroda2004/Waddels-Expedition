using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record HabitacionDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; } = null!;
        [Display(Name= "Capacidad Máxima")]
        public int CapacidadMaxima { get; set; }
        [Display(Name = "Capacidad Mínima")]
        public int CapacidadMinima { get; set; }
        public string? Dimensiones { get; set; }
        public string? Estado { get; set; }
        public virtual List<BarcoHabitacionDTO> BarcoHabitacion { get; set; } = null!;
        public virtual List<PrecioHabitacionesDTO> PrecioHabitaciones { get; set; } = null!;
        public virtual List<ReservaDetalleDTO> ReservaDetalles { get; set; } = null!;
    }
}
