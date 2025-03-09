using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Destino
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Estado { get; set; }

    public virtual ICollection<Puerto> Puerto { get; set; } = new List<Puerto>();
}
