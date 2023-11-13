using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class StudentsRequest
{
    public long StudentsRequestId { get; set; }

    public byte[]? Register { get; set; }

    public long? RequestId { get; set; }

    public virtual Student? RegisterNavigation { get; set; }

    public virtual Request? Request { get; set; }
}
