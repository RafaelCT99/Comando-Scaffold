using System;
using System.Collections.Generic;

namespace Factura_BD_Existente.Models;

public partial class Factura
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Total { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<Detallefactura> Detallefacturas { get; set; } = new List<Detallefactura>();
}
