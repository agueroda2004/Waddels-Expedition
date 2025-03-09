using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Crucero
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public byte[] Foto { get; set; } = null!;

    public int Duracion { get; set; }

    public int BarcoId { get; set; }

    public string? Estado { get; set; }

    public virtual Barco Barco { get; set; } = null!;

    public virtual ICollection<FechasCrucero> FechasCrucero { get; set; } = new List<FechasCrucero>();

    public virtual ICollection<Itinerario> Itinerario { get; set; } = new List<Itinerario>();
}
