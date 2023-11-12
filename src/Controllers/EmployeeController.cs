using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class EmployeeController
{
    private readonly IRepository<Employee>? employeeRepository;

    public EmployeeController(IRepository<Employee>? employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }
    public void CreateEmployee(EmployeeDto employeeDto)
    {
        var employee = new Employee
        {
            Payroll = employeeDto.Payroll,
            CareerId = employeeDto.CareerId,
            UserId = employeeDto.UserId,
            UserType = employeeDto.UserType
        };
        employeeRepository?.Create(employee);
    }
    public IEnumerable<Employee> GetAllEmployees()
    {
        var employees = employeeRepository?.GetAll();
        if (employees == null)
        {
            return new List<Employee>();
        }
        return employees.Select(employee => new Employee
        {
            Payroll = employee.Payroll,
            CareerId = employee.CareerId,
            UserId = employee.UserId,
            UserType = employee.UserType
        });
    }
    public Employee GetEmployeeById(long id)
    {
        var employee = (employeeRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new Employee
        {
            Payroll = employee.Payroll,
            CareerId = employee.CareerId,
            UserId = employee.UserId,
            UserType = employee.UserType
        };
    }
    public void RemoveEmployee(long id)
    {
        var employee = (employeeRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        employeeRepository?.Remove(employee);
    }
    public void UpdateEmployee(Employee employee)
    {
        var employeeToUpdate = employeeRepository?.GetById(employee.UserId ?? throw new ArgumentException("Invalid id")) ?? throw new ArgumentException("Invalid id");
        employeeToUpdate.Payroll = employee.Payroll;
        employeeToUpdate.CareerId = employee.CareerId;
        employeeToUpdate.UserId = employee.UserId;
        employeeToUpdate.UserType = employee.UserType;
        employeeRepository?.Update(employeeToUpdate);
    }
}