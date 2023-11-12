using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class Employee
{
    public string Payroll { get; set; } = null!;

    public long? CareerId { get; set; }

    public long? UserId { get; set; }

    public long? UserType { get; set; }

    public virtual Career? Career { get; set; }

    public virtual ICollection<EmployeeSubject> EmployeeSubjects { get; set; } = new List<EmployeeSubject>();

    public virtual ICollection<MultipleSesRequest> MultipleSesRequests { get; set; } = new List<MultipleSesRequest>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<SingleSesRequest> SingleSesRequests { get; set; } = new List<SingleSesRequest>();

    public virtual User? User { get; set; }
}
