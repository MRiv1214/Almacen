using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class Campus
{
    public long? CampusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
