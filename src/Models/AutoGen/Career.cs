using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class Career
{
    public long CareerId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
