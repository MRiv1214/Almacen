using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class Material
{
    public long? MaterialId { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public virtual ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
