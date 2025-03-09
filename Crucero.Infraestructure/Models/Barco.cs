using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Barco
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int CapacidadMaxima { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<BarcoHabitacion> BarcoHabitacion { get; set; } = new List<BarcoHabitacion>();

    public virtual ICollection<Crucero> Crucero { get; set; } = new List<Crucero>();
}
