using System;
using System.Collections.Generic;

namespace Almacen.Models;

public partial class Student
{
    public long StudentId { get; set; }

    public long? UserId { get; set; }

    public string? CarreerId { get; set; }

    public virtual User? User { get; set; }
}
