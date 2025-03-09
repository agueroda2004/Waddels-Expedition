using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Complemento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public int AplicadoPorId { get; set; }

    public string? Estado { get; set; }

    public virtual AplicadoPor AplicadoPor { get; set; } = null!;

    public virtual ICollection<ReservaComplemento> ReservaComplemento { get; set; } = new List<ReservaComplemento>();
}
