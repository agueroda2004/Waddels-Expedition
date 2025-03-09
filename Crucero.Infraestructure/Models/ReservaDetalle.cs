using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class ReservaDetalle
{
    public int Id { get; set; }

    public int ReservaId { get; set; }

    public int HabitacionId { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public string? Estado { get; set; }

    public virtual Habitacion Habitacion { get; set; } = null!;

    public virtual Reserva Reserva { get; set; } = null!;
}
