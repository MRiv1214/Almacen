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
using Microsoft.EntityFrameworkCore;

namespace src.Controllers;

public class SignInController
{
    AlmacenContext db = AlmacenContext.GetInstance();

    public (User? user, string message) LogIn(string name, byte[] password)
    {
        var user = db.Users
            .Include(user => user.Employee)
            .Include(user => user.Student)
            .SingleOrDefault(user => user.Name == name);

        if (user == null) {
            return (null, "User not found");
        }

        if (SHA256Password.Compare(password, user.Password!)) {
            return (user, "User logged in");
        }

        return (null, "Invalid credentials");
    }
}
