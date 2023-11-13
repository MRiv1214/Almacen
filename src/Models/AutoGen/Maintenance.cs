using System;
using System.Collections.Generic;

namespace Almacen.Models.AutoGen;

public partial class Maintenance
{
    public long MaintenanceId { get; set; }

    public long? MaterialId { get; set; }

    public long? CareerId { get; set; }

    public string? MaintType { get; set; }

    public string? Desc { get; set; }

    public string? SpareParts { get; set; }

    public string? Date { get; set; }

    public string? ScheduleDate { get; set; }

    public virtual Career? Career { get; set; }

    public virtual Material? Material { get; set; }
}
