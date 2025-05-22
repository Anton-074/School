using System;
using System.Collections.Generic;

namespace School;

public partial class Component
{
    public int ComponentId { get; set; }

    public string ComponentName { get; set; } = null!;

    public string? ComponentDescription { get; set; }

    public DateOnly ManufactureDate { get; set; }

    public virtual ICollection<WarehouseStock> WarehouseStocks { get; set; } = new List<WarehouseStock>();
}
