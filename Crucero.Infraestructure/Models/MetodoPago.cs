using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class MetodoPago
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Estado { get; set; }

    public virtual ICollection<Pago> Pago { get; set; } = new List<Pago>();
}
