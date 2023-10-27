using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGenModels;

public partial class User
{
    public long UserId { get; set; }

    public byte[]? Password { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
