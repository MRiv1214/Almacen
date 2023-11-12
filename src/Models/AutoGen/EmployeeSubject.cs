using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class EmployeeSubject
{
    public long? EmployeeSubId { get; set; }

    public string? Payroll { get; set; }

    public long? SubjectId { get; set; }

    public virtual Employee? PayrollNavigation { get; set; }

    public virtual Subject? Subject { get; set; }
}
