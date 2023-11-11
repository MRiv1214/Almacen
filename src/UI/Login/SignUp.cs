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
                CreateUserForm(typeOfUser);
                break;
            case gTeacher:
                CreateUserForm(typeOfUser);
                break;
            case gStudent:
                CreateUserForm(typeOfUser);
                break;
            case gAdmin:
                CreateUserForm(typeOfUser);
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