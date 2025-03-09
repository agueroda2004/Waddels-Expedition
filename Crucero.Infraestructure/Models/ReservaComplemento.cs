using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class ReservaComplemento
{
    public int Id { get; set; }

    public int ReservaId { get; set; }

    public int ComplemtoId { get; set; }

    public int Cantidad { get; set; }

    public virtual Complemento Complemento { get; set; } = null!;

    public virtual Reserva Reserva { get; set; } = null!;
}
