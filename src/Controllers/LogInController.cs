using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
using Almacen.Repository.Sqlite;

namespace src.Controllers;

public class LogInController
{
    private readonly IRepository<User>? userRepository;
    public LogInController(IRepository<User>? userRepository)
    {
        this.userRepository = userRepository;
    }
    public (UserDto? user, string error) LogIn(string name, byte[] password)
    {
        var userController = new UserController(userRepository);
        var user = userController.GetUserByCredentials(password, name);
        if (user == null)
        {
            return (null, "Invalid credentials");
        }
        return (user, "");
    }
}