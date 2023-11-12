using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class MultipleSesRequest
{
    public long? MulSesRequestId { get; set; }

    public long? RequestId { get; set; }

    public string? Payroll { get; set; }

    public string? Period { get; set; }

    public string? InitialDate { get; set; }

    public string? EndDate { get; set; }

    public string? Days { get; set; }

    public virtual Employee? PayrollNavigation { get; set; }

    public virtual Request? Request { get; set; }
}
