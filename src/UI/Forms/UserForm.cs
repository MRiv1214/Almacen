using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.Dtos;
using Almacen.Helpers;
using Almacen.Repository.Sqlite;
using Almacen.Models.AutoGen;

namespace UI.Forms;

public class UserForm : IView
{
    public static long CreateUserForm()
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
        var userRepository = new SqliteRepository<User>(AlmacenContext.GetInstance());
        var userController = new UserController(userRepository);
        var (UserId, message) = userController.CreateUser(userDto);
        AnsiConsole.MarkupLine($"[gray]{message}[/]");
        return UserId;
    }

    public void DoOption(string option)
    {
        throw new NotImplementedException();
    }

    public string GetOption()
    {
        throw new NotImplementedException();
    }
}