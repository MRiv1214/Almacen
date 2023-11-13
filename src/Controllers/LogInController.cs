using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Helpers;
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
    public (User? user, string error) LogIn(string name, byte[] password)
    {
        var userController = new UserController(userRepository);
        var user = userController.GetUserByName(name);
        if (user == null)
        {
            return (null, "User not found");
        }

        if (SHA256Password.Compare(password, user.Password!) == true)
        {
            return (user, "User logged in");
        }
        return (null, "Invalid credentials");
    }
}