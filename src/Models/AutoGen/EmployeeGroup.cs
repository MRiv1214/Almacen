using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class EmployeeGroup
{
    public long EmployeeGroupId { get; set; }

    public string? Payroll { get; set; }

    public long? GroupId { get; set; }

    public virtual Group? Group { get; set; }
}
