using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class EmployeeGroupController
{
    AlmacenContext db = AlmacenContext.GetInstance();
    /*
    private readonly IRepository<EmployeeGroup>? employeeGroupRepository;

    public EmployeeGroupController(IRepository<EmployeeGroup>? employeeGroupRepository)
    {
        this.employeeGroupRepository = employeeGroupRepository;
    }
    public long CreateEmployeeGroup(EmployeeGroupDto employeeGroupDto)
    {
        var employeeGroup = new EmployeeGroup
        {
            Payroll = employeeGroupDto.Payroll,
            GroupId = employeeGroupDto.GroupId,
        };
        employeeGroupRepository?.Create(employeeGroup);
        return employeeGroup.EmployeeGroupId;
    }
    public IEnumerable<EmployeeGroup> GetAllEmployeeGroups()
    {
        var employeeGroups = employeeGroupRepository?.GetAll();
        if (employeeGroups == null)
        {
            return new List<EmployeeGroup>();
        }
        return employeeGroups.Select(employeeGroup => new EmployeeGroup
        {
            EmployeeGroupId = employeeGroup.EmployeeGroupId,
            Payroll = employeeGroup.Payroll,
            GroupId = employeeGroup.GroupId,
        });
    }
    public EmployeeGroup GetEmployeeGroupById(long id)
    {
        var employeeGroup = (employeeGroupRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new EmployeeGroup
        {
            EmployeeGroupId = employeeGroup.EmployeeGroupId,
            Payroll = employeeGroup.Payroll,
            GroupId = employeeGroup.GroupId,
        };
    }
    public void RemoveEmployeeGroup(long id)
    {
        var employeeGroup = (employeeGroupRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        employeeGroupRepository?.Remove(employeeGroup);
    }
    public void UpdateEmployeeGroupDto (EmployeeGroup employeeGroup)
    {
        var employeeGroupToUpdate = employeeGroupRepository?.GetById(employeeGroup.EmployeeGroupId)?? throw new ArgumentException("Invalid id");
        employeeGroupToUpdate.Payroll = employeeGroup.Payroll;
        employeeGroupToUpdate.GroupId = employeeGroup.GroupId;
        employeeGroupRepository?.Update(employeeGroupToUpdate);
    }
    */
}