using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class ClassRoom
{
    public long? ClassroomId { get; set; }

    //apoco es byte el tipo de dato de name?
    public byte[]? Name { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<SubjectClassroom> SubjectClassrooms { get; set; } = new List<SubjectClassroom>();
}
