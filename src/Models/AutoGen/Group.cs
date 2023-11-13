using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class Group
{
    public long GroupId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<EmployeeGroup> EmployeeGroups { get; set; } = new List<EmployeeGroup>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<StudentGroup> StudentGroups { get; set; } = new List<StudentGroup>();
}
