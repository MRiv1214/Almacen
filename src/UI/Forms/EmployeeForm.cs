using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository.Sqlite;
using Almacen.Helpers;
using System.Data.Common;

namespace UI.Forms;

public class EmployeeForm : IView
{
    private static EmployeeController employeeController = new();
    private static UserController userController = new();
    private Employee? employee;

    public string GetOption()
    {
        throw new NotImplementedException();
    }

    public void DoOption(string option)
    {
        throw new NotImplementedException();
    }
    private void CreateEmployee()
    {
        AnsiConsole.Markup("[blue]Create Employee[/]\n");
        // Select Type of User
        ViewManager.ExecuteView(new SelectUser());
        
        var data = ViewManager.data switch
        {
            (UserType asUserType,long careerId) => (asUserType, careerId),
            string error => throw new SystemException(error),
            _ => throw new SystemException("ERROR: Unreachable code")
        };
        var user = new User
        {
            Name = AnsiConsole.Ask<string>("Enter your name:"),
            LastName = AnsiConsole.Ask<string>("Enter your last name:"),
            Password = SHA256Password.Encrypt(AnsiConsole.Ask<string>("Enter your password:")),
            Employee = new Employee
            {
                Payroll = AnsiConsole.Ask<string>("Enter your payroll:"),
                CareerId = data.careerId,
                UserType = (long)data.asUserType,
            }
        };
        userController.CreateUser(user);
    }

    private void SelectEmployee()
    {
        /*
        var employees = userController.GetAllUsers();
        var employeesPayroll = new List<string>();
        foreach (var employee in employees)
        {
            employeesPayroll.Add(employee.Payroll!);
        }
        Payroll = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Select a employee")
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to reveal more employees)[/]")
            .AddChoices(employeesPayroll));
        */
    }

    private void UpdateEmployee()
    {
        /*
        AnsiConsole.Markup("[blue]Update Employee[/]\n");
        Payroll = AnsiConsole.Ask<string>("Enter your payroll:");
        employeeController.UpdateEmployee(UserId, Payroll, CareerId, UserType);
        */
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
