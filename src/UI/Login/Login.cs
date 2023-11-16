
using Almacen.Models.AutoGen;
using UI;

namespace UI.Login;

public class Login : IView
{
    public const string singIn = "Sign In", signUp = "Sign Up", exit = "Exit";
    //Console Login
    public User? user = null;

    string IView.GetOption()
    {
        Clear();
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(4)
                .AddChoices(new[] {
                    singIn, signUp, exit
        }));
        return userSelection;
    }

    void IView.DoOption(string option)
    {
        switch (option)
        {
            case singIn:
                // user = SignIn.Sign_In();
                ViewManager.Next(new SignIn());
                break;
            case signUp:
                // SignUp.Sign_Up();
                ViewManager.Next(new SignUp());
                break;
            case exit:
                Environment.Exit(0);
                break;
        }
        return; //"tu mama we";
    }

}
