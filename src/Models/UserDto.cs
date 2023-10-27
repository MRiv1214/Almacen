using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Almacen.Models.AutoGenModels;
using Microsoft.EntityFrameworkCore;
namespace Almacen.Models;

public class UserDto 
{
    public static void CreateTeacher(string name, string lastName, string password, string payroll)
    {
        using var db = new AlmacenDBContext();

        var user = Create(name, lastName, password);

        var employee = new Employee
        {
            EmployeeId = payroll,
            CareerId = null,
            UserId = user.UserId,
            UserType = 1
        };
        db.Employees.Add(employee);
        db.SaveChanges();
    }
    public static void CreateStoreKeeper(string name, string lastName, string password, string payroll)
    {
        using var db = new AlmacenDBContext();

        var user = Create(name, lastName, password);

        var employee = new Employee
        {
            EmployeeId = payroll,
            CareerId = null,
            UserId = user.UserId,
            UserType = 2
        };
        db.Employees.Add(employee);
        db.SaveChanges();
    }
    public static void CreateCoordinator(string name, string lastName, string password, string payroll)
    {
        using var db = new AlmacenDBContext();

        var user = Create(name, lastName, password);

        var employee = new Employee
        {
            EmployeeId = payroll,
            CareerId = null,
            UserId = user.UserId,
            UserType = 3
        };
        db.Employees.Add(employee);
        db.SaveChanges();
    }
    public static void CreateStudent(string name, string lastName, string password, long studentId)
    {
        using var db = new AlmacenDBContext();

        var user = Create(name, lastName, password);

        var student = new Student
        {
            StudentId = studentId,
            CarreerId = null,
            UserId = user.UserId
        };
        db.Students.Add(student);
        db.SaveChanges();
    }
    private static User Create(string name, string lastName, string password)
    {
        using var db = new AlmacenDBContext();
        var user = new User
        {
            Name = name,
            LastName = lastName,
            Password = Helpers.SHA256Password.Encrypt(password)
        };
        db.Users.Add(user);
        db.SaveChanges();
        return user;
    }
    
    public static void DeleteUserById(long userId)
    {
        using (var db = new AlmacenDBContext()) 
        {
            db.Users.Where(u => u.UserId == userId).ExecuteDelete();
            
            /*
            DELETE FROM [u]
            FROM [Users] AS [u]
            WHERE [u].[UserId] = ?
            */
        }
    }
    public static bool Exists(long userId)
    {
        using var db = new AlmacenDBContext();
        return db.Users.Any(u => u.UserId == userId);
    }
    public static bool IsTeacher(long userId)
    {
        using var db = new AlmacenDBContext();
        return db.Employees.Any(e => e.UserId == userId && e.UserType == 1);
    }
    public static bool IsStoreKeeper(long userId)
    {
        using var db = new AlmacenDBContext();
        return db.Employees.Any(e => e.UserId == userId && e.UserType == 2);
    }
    public static bool IsStudent(long userId)
    {
        using var db = new AlmacenDBContext();
        return db.Students.Any(s => s.UserId == userId);
    }
    
}