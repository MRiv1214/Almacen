using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class EmployeeController
{
    AlmacenContext db = AlmacenContext.GetInstance();
    /*
    private readonly IRepository<Employee>? employeeRepository;

    public EmployeeController(IRepository<Employee>? employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }
    public string CreateEmployee(EmployeeDto employeeDto)
    {
        var employee = new Employee
        {
            Payroll = employeeDto.Payroll,
            CareerId = employeeDto.CareerId,
            UserId = employeeDto.UserId,
            UserType = employeeDto.UserType
        };
        employeeRepository?.Create(employee);
        return employee.Payroll;
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
    public Employee? GetEmployeeByPayroll(string payroll)
    {
        var employee = employeeRepository?.GetSingleBy(employee => employee.Payroll == payroll);
        if (employee == null)
        {
            return null;
        }
        return new Employee
        {
            Payroll = employee.Payroll,
            CareerId = employee.CareerId,
            UserId = employee.UserId,
            UserType = employee.UserType
        };
    }

    public Employee? GetEmployeeByUserId(long id)
    {
        var employee = employeeRepository?.GetSingleBy(x => x.UserId == id);
        if (employee == null)
        {
            return null;
        }
        return new Employee
        {
            Payroll = employee.Payroll,
            CareerId = employee.CareerId,
            UserId = employee.UserId,
            UserType = employee.UserType
        };
    }
    public void RemoveEmployee(string id)
    {
        var employee = (employeeRepository?.GetSingleBy(x => x.Payroll == id)) ?? throw new ArgumentException("Invalid id");
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

    internal object GetEmployeeByPayroll(byte[] employeePayrollBytes)
    {
        throw new NotImplementedException();
    }
    */
}