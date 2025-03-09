using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Puerto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public int DestinoId { get; set; }

    public string? Estado { get; set; }

    public virtual Destino Destino { get; set; } = null!;

    public virtual ICollection<Itinerario> Itinerario { get; set; } = new List<Itinerario>();
}
