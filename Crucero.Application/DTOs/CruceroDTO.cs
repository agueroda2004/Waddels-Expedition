using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Crucero.Application.DTOs
{
    public record CruceroDTO
    {
        [ValidateNever]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} es un dato requerido")]
        public string Nombre { get; set; } = null!;
        public byte[] Foto { get; set; } = null!;
        [Required(ErrorMessage = "{0} es un dato requerido")]
        public int Duracion { get; set; }
        [Required(ErrorMessage = "{0} es un dato requerido")]
        public int BarcoId { get; set; }
        [ValidateNever]
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        [ValidateNever]
        public virtual List<FechasCruceroDTO> FechasCrucero { get; set; } = null!;
        [ValidateNever]
        public virtual List<ItinerarioDTO> Itinerario { get; set; } = new List<ItinerarioDTO>();
        [ValidateNever]
        public virtual BarcoDTO Barco { get; set; } = null!;
    }
}
