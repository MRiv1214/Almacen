
using Util.UserFactory;
namespace UI.Login;

public class SignUp : Login
{
    //Console Sign Up
    public static void Sign_Up()
    {
        // login with user and password or create new user
        AnsiConsole.Markup("[blue]Sign Up[/]\n");
        var typeOfUser = SelectUser();
        switch (typeOfUser)
        {
            case gStoreKeeper:
                CreateUserForm(IUserFactory.storekeeper);
                break;
            case gTeacher:
                CreateUserForm(IUserFactory.teacher);
                break;
            case gStudent:
                CreateUserForm(IUserFactory.student);
                break;
            case gAdmin:
                CreateUserForm(IUserFactory.admin);
                break;
            case exit:
                Environment.Exit(0);
                break;
        }
    }
    private static void CreateUserForm(string typeOfUser)
    {
        throw new NotImplementedException();
    }
}