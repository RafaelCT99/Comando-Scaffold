using System;
using System.Collections.Generic;

namespace Factura_BD_Existente.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public decimal? Precio { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Detallefactura> Detallefacturas { get; set; } = new List<Detallefactura>();
}
