using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class BarcoHabitacion
{
    public int Id { get; set; }

    public int IdHabitacion { get; set; }

    public int IdBarco { get; set; }

    public int Cantidad { get; set; }

    public virtual Barco IdBarcoNavigation { get; set; } = null!;

    public virtual Habitacion IdHabitacionNavigation { get; set; } = null!;
}
