using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.Dtos;
using Almacen.Helpers;
using Almacen.Repository.Sqlite;
using Almacen.Models.AutoGen;

namespace Almacen.UI.Forms;

public static class UserForm
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
        var UserId = userController.CreateUser(userDto); 
        return UserId;
    }
}