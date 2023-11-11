using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class User
{
    public long UserId { get; set; }

    public byte[]? Password { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
