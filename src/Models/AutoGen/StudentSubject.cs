using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class StudentSubject
{
    public long StudentSubId { get; set; }

    public byte[]? Register { get; set; }

    public long? SubjectId { get; set; }

    public virtual Student? RegisterNavigation { get; set; }

    public virtual Subject? Subject { get; set; }
}
