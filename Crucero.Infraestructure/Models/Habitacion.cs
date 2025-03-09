using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crucero.Infraestructure.Models;

public partial class Habitacion
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int CapacidadMaxima { get; set; }

    public int CapacidadMinima { get; set; }

    public string? Dimensiones { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<BarcoHabitacion> BarcoHabitacion { get; set; } = new List<BarcoHabitacion>();

    public virtual ICollection<PrecioHabitaciones> PrecioHabitaciones { get; set; } = new List<PrecioHabitaciones>();

    public virtual ICollection<ReservaDetalle> ReservaDetalle { get; set; } = new List<ReservaDetalle>();
}
