using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Reserva
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public int FechaCruceroId { get; set; }

    public int CantidadHabitaciones { get; set; }

    public int CantidadPasajeros { get; set; }

    public decimal Total { get; set; }

    public decimal Pagado { get; set; }

    public int EstadoId { get; set; }

    public virtual EstadoReserva Estado { get; set; } = null!;

    public virtual FechasCrucero FechasCrucero { get; set; } = null!;

    public virtual ICollection<Ocupantes> Ocupantes { get; set; } = new List<Ocupantes>();

    public virtual ICollection<Pago> Pago { get; set; } = new List<Pago>();

    public virtual ICollection<ReservaComplemento> ReservaComplemento { get; set; } = new List<ReservaComplemento>();

    public virtual ICollection<ReservaDetalle> ReservaDetalle { get; set; } = new List<ReservaDetalle>();

    public virtual Usuario Usuario { get; set; } = null!;
}
