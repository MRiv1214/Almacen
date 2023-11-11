using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class Subject
{
    public long SubjectId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<EmployeeSubject> EmployeeSubjects { get; set; } = new List<EmployeeSubject>();

    public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();

    public virtual ICollection<SubjectClassroom> SubjectClassrooms { get; set; } = new List<SubjectClassroom>();
}
