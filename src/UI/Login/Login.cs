
using Almacen.Models.AutoGen;

namespace UI.Login;

public class Login : View
{
    public const string singIn = "Sign In", signUp = "Sign Up", exit = "Exit";
    //Console Login
    public static User? ConsoleLogin()
    {
        User? user = null;
        // login with user and password or create new user
        Clear();
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(4)
                .AddChoices(new[] {
                    singIn, signUp, exit
        }));
        switch (userSelection)
        {
            case singIn:
                user = SignIn.Sign_In();
                break;
            case signUp:
                SignUp.Sign_Up();
                break;
            case exit:
                Environment.Exit(0);
                break;
        }
        return user;
    }
}