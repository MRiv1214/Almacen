using Almacen.Helpers;
using UI.Forms;
using Almacen.Models;
using Almacen.Models.AutoGen;
using Almacen.Controllers;
namespace UI.Login;


public class SignUp : IView
{
    const long employeeCareerId = 9; // magia we
    // public static long? UserId { get; set; }
    private long CareerId { get; set; }
    private UserType typeOfUser { get; set; }
    private long userId { get; set; }

    public string GetOption()
    {
        ViewManager.ExecuteView(new UserForm());

        userId = ViewManager.data switch
        {
            long asUserId => asUserId,
            string error => throw new SystemException(error),
            _ => throw new SystemException("ERROR: Unreachable code")
        };

        AnsiConsole.Markup("[blue]Sign Up[/]\n");


        // TODO: Call SelectUserForm inside view manager and retrieve typeOfUser
        // typeOfUser = SelectUser.SelectUserForm();

        return "chido";
    }

    public void DoOption(string option)
    {
        switch (typeOfUser) {
        case UserType.StoreKeeper:
            ViewManager.ExecuteView(new EmployeeForm());
            CareerId = ViewManager.data switch
            {
                long asCareerId => asCareerId,
                string error => throw new SystemException(error),
                _ => throw new SystemException("ERROR: Unreachable code")
            };
            break;
        case UserType.Teacher:
            ViewManager.ExecuteView(new CareerForm());
            CareerId = ViewManager.data switch
            {
                long asCareerId => asCareerId,
                string error => throw new SystemException(error),
                _ => throw new SystemException("ERROR: Unreachable code")
            };
            ViewManager.ExecuteView(new EmployeeForm());
            break;
        case UserType.Student:
            ViewManager.ExecuteView(new CareerForm());
            CareerId = ViewManager.data switch
            {
                long asCareerId => asCareerId,
                string error => throw new SystemException(error),
                _ => throw new SystemException("ERROR: Unreachable code")
            };
            ViewManager.ExecuteView(new StudentForm());
            break;
        case UserType.Admin:
            ViewManager.ExecuteView(new CareerForm());
            CareerId = ViewManager.data switch
            {
                long asCareerId => asCareerId,
                string error => throw new SystemException(error),
                _ => throw new SystemException("ERROR: Unreachable code")
            };
            ViewManager.ExecuteView(new EmployeeForm());
            break;
        }
    }

}
