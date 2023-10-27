using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGenModels;

public partial class Employee
{
    public string EmployeeId { get; set; } = null!;

    public string? CareerId { get; set; }

    public long? UserId { get; set; }

    public long? UserType { get; set; }
}
