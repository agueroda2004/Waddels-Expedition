using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record BarcoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        [Display(Name ="Capacidad Máxima")]
        public int CapacidadMaxima { get; set; }
        public string? Estado { get; set; }
        public virtual List<CruceroDTO> Crucero { get; set; } = null!;
        public virtual List<BarcoHabitacionDTO> BarcoHabitacion { get; set; } = null!;
    }
}
