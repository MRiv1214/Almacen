using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class StudentGroup
{
    public long StudentGroupId { get; set; }

    public byte[]? Register { get; set; }

    public long? GroupId { get; set; }

    public virtual Group? Group { get; set; }

    public virtual Student? RegisterNavigation { get; set; }
}
