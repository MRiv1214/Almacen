using Almacen.Controllers;
using Almacen.Models.Dtos;
using Almacen.Helpers;
using Almacen.Repository;
using Almacen.Models.AutoGen;
using Almacen.Repository.Sqlite;
using Almacen.UI.Forms;
using UI.Forms;
namespace UI.Login;

public class SignUp 
{
    //Console Sign Up
    public static void Sign_Up()
    {
        // login with user and password to create new user
        var UserId = UserForm.CreateUserForm();
        long CareerId;
        AnsiConsole.Markup("[blue]Sign Up[/]\n");
        var typeOfUser = SelectUser.SelectUse();
        switch (typeOfUser)
        {
            case UserType.StoreKeeper:
                EmployeeForm.CreateEmployee(UserId, 9, UserType.StoreKeeper);
                break;
            case UserType.Teacher:
                CareerId = CareerForm.SelectCareer();
                EmployeeForm.CreateEmployee(UserId, CareerId, UserType.Teacher);
                break;
            case UserType.Student:
                CareerId = CareerForm.SelectCareer();
                StudentForm.CreateStudent(UserId, CareerId);
                break;
            case UserType.Admin:
                CareerId = CareerForm.SelectCareer();
                EmployeeForm.CreateEmployee(UserId, CareerId, UserType.Admin);
                break;
        }
    }
    
}