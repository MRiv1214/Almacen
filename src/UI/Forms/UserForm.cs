using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.Dtos;
using Almacen.Helpers;
using Almacen.Repository.Sqlite;
using Almacen.Models.AutoGen;
using UI.Login;

namespace UI.Forms;

public class UserForm : IView
{
    private UserController userController = new();

    public string GetOption()
    {
        var name = AnsiConsole.Ask<string>("Enter your name:");
        var lastName = AnsiConsole.Ask<string>("Enter your last name:");
        var password = AnsiConsole.Ask<string>("Enter your password:");
        var userDto = new UserDto
        {
            Name = name,
            LastName = lastName,
            Password = SHA256Password.Encrypt(password),
        };
        var (UserId, message) = userController.CreateUser(userDto);
        if (message != null) {
            ViewManager.data = message;
        } else {
            ViewManager.data = UserId;
        }

        AnsiConsole.MarkupLine($"[gray]{message}[/]");
        return "";
    }

    public void DoOption(string option)
    {
        throw new SystemException("ERROR: Unreachable code");
    }

}
