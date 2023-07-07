using System;
using System.Collections.Generic;

namespace MCreditos.Models;

public partial class Pago
{
    public int Id { get; set; }

    public int? PersonaId { get; set; }

    public decimal Monto { get; set; }

    public int PeriodoPago { get; set; }

    public DateTime FechaPago { get; set; }

    public bool Estado { get; set; }

    public virtual Persona? Persona { get; set; }
}
