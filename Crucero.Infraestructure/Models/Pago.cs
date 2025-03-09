using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Pago
{
    public int Id { get; set; }

    public int ReservaId { get; set; }

    public decimal Monto { get; set; }

    public DateOnly FechaPago { get; set; }

    public int MetodoId { get; set; }

    public int TarjetaNumero { get; set; }

    public string? Estado { get; set; }

    public virtual MetodoPago Metodo { get; set; } = null!;

    public virtual Reserva Reserva { get; set; } = null!;
}
