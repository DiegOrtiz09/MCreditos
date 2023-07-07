using System;
using System.Collections.Generic;

namespace MCreditos.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string ApellidoMaterno { get; set; } = null!;

    public decimal CantidadPrestada { get; set; }

    public string? Telefono { get; set; }

    public string Email { get; set; } = null!;

    public DateTime FechaPrestamo { get; set; }

    public short DiaCobro { get; set; }

    public int MesesPrestamo { get; set; }

    public short Intereses { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
