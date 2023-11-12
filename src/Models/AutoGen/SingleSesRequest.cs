using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class SingleSesRequest
{
    public long? SinSesReqId { get; set; }

    public long? RequestId { get; set; }

    public string? Payroll { get; set; }

    public string? Level { get; set; }

    public string? Period { get; set; }

    public virtual Employee? PayrollNavigation { get; set; }

    public virtual Request? Request { get; set; }
}
