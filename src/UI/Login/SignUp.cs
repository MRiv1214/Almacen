using Almacen.Helpers;
using UI.Forms;
namespace UI.Login;

public class SignUp : IView
{
    //Console Sign Up
    public static void Sign_Up()
    {
        // login with user and password to create new user
        var UserId = UserForm.CreateUserForm();
        long CareerId;
        AnsiConsole.Markup("[blue]Sign Up[/]\n");
        var typeOfUser = SelectUser.SelectUserForm();
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

    public void DoOption(string option)
    {
        throw new NotImplementedException();
    }

    public string GetOption()
    {
        throw new NotImplementedException();
    }
}