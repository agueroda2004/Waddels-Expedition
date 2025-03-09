using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Usuario1 { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Pais { get; set; } = null!;

    public int RolId { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Notificacion> Notificacion { get; set; } = new List<Notificacion>();

    public virtual ICollection<Reserva> Reserva { get; set; } = new List<Reserva>();

    public virtual Rol Rol { get; set; } = null!;
}
