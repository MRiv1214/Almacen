using Almacen.Models.AutoGen;
using Almacen.Repository;
using Almacen.Models.Dtos;

namespace Almacen.Controllers;

public class EmployeeSubjectController
{
    private readonly IRepository<EmployeeSubject>? employeeSubjectRepository;
    public EmployeeSubjectController(IRepository<EmployeeSubject>? employeeSubjectRepository)
    {
        this.employeeSubjectRepository = employeeSubjectRepository;
    }
    public long CreateEmployeeSubject(EmployeeSubjectDto employeeSubjectDto)
    {
        var employeeSubject = new EmployeeSubject
        {
            Payroll = employeeSubjectDto.Payroll,
            SubjectId = employeeSubjectDto.SubjectId,
        };
        employeeSubjectRepository?.Create(employeeSubject);
        return employeeSubject.EmployeeSubId;
    }
    public IEnumerable<EmployeeSubject> GetAllEmployeeSubjects()
    {
        var employeeSubjects = employeeSubjectRepository?.GetAll();
        if (employeeSubjects == null)
        {
            return new List<EmployeeSubject>();
        }
        return employeeSubjects.Select(employeeSubject => new EmployeeSubject
        {
            EmployeeSubId = employeeSubject.EmployeeSubId,
            Payroll = employeeSubject.Payroll,
            SubjectId = employeeSubject.SubjectId,
        });
    }
    public EmployeeSubject GetEmployeeSubjectById(long id)
    {
        var employeeSubject = (employeeSubjectRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new EmployeeSubject
        {
            EmployeeSubId = employeeSubject.EmployeeSubId,
            Payroll = employeeSubject.Payroll,
            SubjectId = employeeSubject.SubjectId,
        };
    }
    public void RemoveEmployeeSubject(long id)
    {
        var employeeSubject = (employeeSubjectRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        employeeSubjectRepository?.Remove(employeeSubject);
    }
    public void UpdateEmployeeSubject(EmployeeSubject employeeSubject)
    {
        var employeeSubjectToUpdate = employeeSubjectRepository?.GetById(employeeSubject.EmployeeSubId)?? throw new ArgumentException("Invalid id");
        employeeSubjectToUpdate.Payroll = employeeSubject.Payroll;
        employeeSubjectToUpdate.SubjectId = employeeSubject.SubjectId;
        employeeSubjectRepository?.Update(employeeSubjectToUpdate);
    }
        
}
