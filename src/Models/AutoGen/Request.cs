using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class Request
{
    public long? RequestId { get; set; }

    public long? CampusId { get; set; }

    public long? ClassroomId { get; set; }

    public long? CareerId { get; set; }

    public long? GroupId { get; set; }

    public string? Payroll { get; set; }

    public long? MaterialId { get; set; }

    public string? DepartureTime { get; set; }

    public string? DeliveryTime { get; set; }

    public string? Date { get; set; }

    public byte[]? MatAmount { get; set; }

    public long? AuthSignature { get; set; }

    public byte[]? ControlNum { get; set; }

    public virtual Campus? Campus { get; set; }

    public virtual Career? Career { get; set; }

    public virtual ClassRoom? Classroom { get; set; }

    public virtual Group? Group { get; set; }

    public virtual Material? Material { get; set; }

    public virtual ICollection<MultipleSesRequest> MultipleSesRequests { get; set; } = new List<MultipleSesRequest>();

    public virtual Employee? PayrollNavigation { get; set; }

    public virtual ICollection<SingleSesRequest> SingleSesRequests { get; set; } = new List<SingleSesRequest>();

    public virtual ICollection<StudentsRequest> StudentsRequests { get; set; } = new List<StudentsRequest>();
}
