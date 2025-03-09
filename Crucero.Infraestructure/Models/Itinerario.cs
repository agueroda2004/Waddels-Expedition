using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Itinerario
{
    public int Id { get; set; }

    public int CruceroId { get; set; }

    public int PuertoId { get; set; }

    public string Dia { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual Crucero Crucero { get; set; } = null!;

    public virtual Puerto Puerto { get; set; } = null!;
}
