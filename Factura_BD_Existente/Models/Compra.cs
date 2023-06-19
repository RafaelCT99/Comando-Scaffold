using System;
using System.Collections.Generic;

namespace Factura_BD_Existente.Models;

public partial class Compra
{
    public int Id { get; set; }

    public string? Proveedor { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? ProductoId { get; set; }

    public int? Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public virtual Producto? Producto { get; set; }
}
