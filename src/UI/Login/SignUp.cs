using Almacen.Helpers;
using UI.Forms;
namespace UI.Login;

public class SignUp : IView
{
    const long employeeCarrerId = 9; // magia we
    public static long? UserId { get; set; }

    public string GetOption()
    {
        ViewManager.ExecuteView(new UserForm());
        long CareerId;
        AnsiConsole.Markup("[blue]Sign Up[/]\n");
        var typeOfUser = SelectUser.SelectUserForm();
        switch (typeOfUser)
        {
            case UserType.StoreKeeper:
                EmployeeForm.CreateEmployee(UserId, employeeCarrerId, UserType.StoreKeeper);
                break;
            case UserType.Teacher:
                CareerId = CareerForm.SelectCareer();
                EmployeeForm.CreateEmployee(UserId, CareerId, UserType.Teacher);
                break;
            case UserType.Student:
                CareerId = CareerForm.SelectCareer();
                _ = StudentForm.CreateStudent(UserId, CareerId);
                break;
            case UserType.Admin:
                CareerId = CareerForm.SelectCareer();
                EmployeeForm.CreateEmployee(UserId, CareerId, UserType.Admin);
                break;
        }
        return "";
    }

    public void DoOption(string option)
    {
        ViewManager.Next(new SignIn());
    }

}
