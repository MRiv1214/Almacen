using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class SubjectClassroom
{
    public long SubClassId { get; set; }

    public long? SubjectId { get; set; }

    public long? ClassroomId { get; set; }

    public virtual ClassRoom? Classroom { get; set; }

    public virtual Subject? Subject { get; set; }
}
