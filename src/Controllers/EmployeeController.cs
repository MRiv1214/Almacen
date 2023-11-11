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
}