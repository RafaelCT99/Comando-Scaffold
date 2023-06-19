using System;
using System.Collections.Generic;

namespace Factura_BD_Existente.Models;

public partial class Detallefactura
{
    public int Id { get; set; }

    public int? FacturaId { get; set; }

    public int? ProductoId { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual Factura? Factura { get; set; }

    public virtual Producto? Producto { get; set; }
}
