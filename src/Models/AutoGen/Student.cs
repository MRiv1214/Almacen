using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class Student
{
    public byte[] Register { get; set; } = null!;

    public long? UserId { get; set; }

    public long? CareerId { get; set; }

    public virtual Career? Career { get; set; }

    public virtual ICollection<StudentGroup> StudentGroups { get; set; } = new List<StudentGroup>();

    public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();

    public virtual ICollection<StudentsRequest> StudentsRequests { get; set; } = new List<StudentsRequest>();

    public virtual User? User { get; set; }
}
