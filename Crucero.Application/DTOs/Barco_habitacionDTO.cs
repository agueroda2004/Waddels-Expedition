using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record BarcoHabitacionDTO
    {
        public int Id { get; set; }
        public int IdHabitacion { get; set; }
        public int IdBarco { get; set; }
        public int Cantidad { get; set; }
        public virtual BarcoDTO Barco { get; set; } = null!;
        public virtual HabitacionDTO IdHabitacionNavigation { get; set; } = null!;
    }
}
