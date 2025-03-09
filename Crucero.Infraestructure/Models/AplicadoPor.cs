using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class AplicadoPor
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Estado { get; set; }

    public virtual ICollection<Complemento> Complemento { get; set; } = new List<Complemento>();
}
