using Almacen.Models.AutoGen;
using Almacen.Repository;
using Almacen.Models.Dtos;

namespace Almacen.Controllers;

public class MaintenanceController
{
    private readonly IRepository<Maintenance>? maintenanceRepository;
    public MaintenanceController(IRepository<Maintenance>? maintenanceRepository)
    {
        this.maintenanceRepository = maintenanceRepository;
    }
    public void CreateMaintenance(MaintenanceDto maintenanceDto)
    {
        var maintenance = new Maintenance
        {
            MaterialId = maintenanceDto.MaterialId,
            CareerId = maintenanceDto.CareerId,
            MaintType = maintenanceDto.MaintType,
            Desc = maintenanceDto.Desc,
            SpareParts = maintenanceDto.SpareParts,
            Date = maintenanceDto.Date,
            ScheduleDate = maintenanceDto.ScheduleDate,
        };
        maintenanceRepository?.Create(maintenance);
    }
    public IEnumerable<Maintenance> GetAllMaintenances()
    {
        var maintenances = maintenanceRepository?.GetAll();
        if (maintenances == null)
        {
            return new List<Maintenance>();
        }
        return maintenances.Select(maintenance => new Maintenance
        {
            MaintenanceId = maintenance.MaintenanceId,
            MaterialId = maintenance.MaterialId,
            CareerId = maintenance.CareerId,
            MaintType = maintenance.MaintType,
            Desc = maintenance.Desc,
            SpareParts = maintenance.SpareParts,
            Date = maintenance.Date,
            ScheduleDate = maintenance.ScheduleDate,
        });
    }
    public Maintenance GetMaintenanceById(long id)
    {
        var maintenance = (maintenanceRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new Maintenance
        {
            MaintenanceId = maintenance.MaintenanceId,
            MaterialId = maintenance.MaterialId,
            CareerId = maintenance.CareerId,
            MaintType = maintenance.MaintType,
            Desc = maintenance.Desc,
            SpareParts = maintenance.SpareParts,
            Date = maintenance.Date,
            ScheduleDate = maintenance.ScheduleDate,
        };
    }
    public void RemoveMaintenance(long id)
    {
        var maintenance = (maintenanceRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        maintenanceRepository?.Remove(maintenance);
    }
    public void UpdateMaintenance(Maintenance maintenance)
    {
        var maintenanceToUpdate = maintenanceRepository?.GetById(maintenance.MaintenanceId ?? throw new ArgumentException("Invalid id"))?? throw new ArgumentException("Invalid id");
        maintenanceToUpdate.MaterialId = maintenance.MaterialId;
        maintenanceToUpdate.CareerId = maintenance.CareerId;
        maintenanceToUpdate.MaintType = maintenance.MaintType;
        maintenanceToUpdate.Desc = maintenance.Desc;
        maintenanceToUpdate.SpareParts = maintenance.SpareParts;
        maintenanceToUpdate.Date = maintenance.Date;
        maintenanceToUpdate.ScheduleDate = maintenance.ScheduleDate;
        maintenanceRepository?.Update(maintenanceToUpdate);
    }
}
