using System;
using System.Collections.Generic;

namespace Factura_BD_Existente.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
