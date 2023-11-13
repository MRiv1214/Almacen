
namespace UI.Login;

public class Login
{
    public const string singIn = "Sign In", signUp = "Sign Up", exit = "Exit";
    public const string gStoreKeeper = "StoreKeeper", gTeacher = "Teacher", gStudent = "Student", gAdmin = "Admin";
    
    public static UserType SelectUser()
    {
        Clear();
        var typeOfUser = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select your type of user")
                .PageSize(4)
                .AddChoices(new[] {
                    gAdmin, gStoreKeeper, gTeacher, gStudent
        }));
        // select type of user
        UserType userType = typeOfUser switch
        {
            gAdmin => UserType.Admin,
            gStoreKeeper => UserType.StoreKeeper,
            gTeacher => UserType.Teacher,
            gStudent => UserType.Student,
            _ => throw new ArgumentException("Invalid type of user")
        };
        return userType;
    }
    //Console Login
    public static void ConsoleLogin()
    {
        // login with user and password or create new user
        Clear();
        var user = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(4)
                .AddChoices(new[] {
                    singIn, signUp, exit
        }));
        switch (user)
        {
            case singIn:
                SignIn.Sign_In();
                break;
            case signUp:
                SignUp.Sign_Up();
                break;
            case exit:
                Environment.Exit(0);
                break;
        }
    }
}