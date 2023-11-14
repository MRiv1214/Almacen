using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository.Sqlite;
using UI.Login;

namespace Almacen.UI.Forms;

public class EmployeeForm
{
    private static readonly SqliteRepository<Employee> employeeRepository = new(AlmacenContext.GetInstance());
    private static readonly EmployeeController employeeController = new(employeeRepository);
    internal static void CreateEmployee(long userId, long careerId, UserType userType)
    {
        AnsiConsole.Markup("[blue]Create Employee[/]\n");
        var employeeDto = new EmployeeDto
        {
            Payroll = AnsiConsole.Ask<string>("Enter your payroll:"),
            UserId = userId,
            CareerId = careerId,
            UserType = (long) userType
        };
        employeeController.CreateEmployee(employeeDto);
    }

}