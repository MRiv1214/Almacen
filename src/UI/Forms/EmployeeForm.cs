using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository.Sqlite;
using Almacen.Helpers;


namespace UI.Forms;

public class EmployeeForm : IView
{
    EmployeeForm(long userId, long employeeId, UserType userType)
    {
        UserId = userId;
        EmployeeId = employeeId;
        UserType = userType;
    }

    private static EmployeeController employeeController = new();
    public string GetOption()
    {
        throw new NotImplementedException();
    }

    public void DoOption(string option)
    {
        throw new NotImplementedException();
    }

    // internal static void CreateEmployee(long userId, long careerId, UserType userType)
    // {
    //     AnsiConsole.Markup("[blue]Create Employee[/]\n");
    //     var employeeDto = new EmployeeDto
    //     {
    //         Payroll = AnsiConsole.Ask<string>("Enter your payroll:"),
    //         UserId = userId,
    //         CareerId = careerId,
    //         UserType = (long)userType
    //     };
    //     employeeController.CreateEmployee(employeeDto);
    // }
    //
    // internal static string SelectEmployee()
    // {
    //     var employees = employeeController.GetAllEmployees();
    //     var employeesPayroll = new List<string>();
    //     foreach (var employee in employees)
    //     {
    //         employeesPayroll.Add(employee.Payroll!);
    //     }
    //     var employeePayroll = AnsiConsole.Prompt(
    //     new SelectionPrompt<string>()
    //         .Title("Select a employee")
    //         .PageSize(10)
    //         .MoreChoicesText("[grey](Move up and down to reveal more employees)[/]")
    //         .AddChoices(employeesPayroll));
    //     return employeeController.GetEmployeeByPayroll(employeePayroll)!.Payroll;
    // }
    //
    // internal static void UpdateEmployee()
    // {
    //     AnsiConsole.Markup("[blue]Update Employee[/]\n");
    //     var employee = employeeController.GetEmployeeByPayroll(SelectEmployee())!;
    //     employee.Payroll = AnsiConsole.Ask<string>("Enter your payroll:");
    //     employeeController.UpdateEmployee(employee);
    // }
    //
    // internal static void RemoveEmployee()
    // {
    //     AnsiConsole.Markup("[blue]Remove Employee[/]\n");
    //     employeeController.RemoveEmployee(SelectEmployee());
    // }
}
