using Almacen.Helpers;
using Almacen.Models.AutoGen;
using Almacen.Repository.Sqlite;
using src.Controllers;
using UI.Menu;

namespace UI.Login;

public class SignIn : IView
{
    private LogInController logInController;
    private User? user = null;

    public void DoOption(string option)
    {
        // ViewManager.Next(new UserView(user));
    }

    public string GetOption()
    {
        string message;
        do {
            Clear();
            AnsiConsole.Markup("[blue]Sign In[/]\n");
            var username = AnsiConsole.Ask<string>("Enter your user name:");
            var passwordRequest = SHA256Password.Encrypt(
                    AnsiConsole.Prompt(
                        new TextPrompt<string>("Enter your password:")
                        .PromptStyle("gray")
                        .Secret()));

            (user, message) = logInController.LogIn(username, passwordRequest);
            if (user == null) {
                AnsiConsole.MarkupLine($"[red]{message}[/]");
                AnsiConsole.MarkupLine("[red]Press any key to continue...[/]");
                _ = ReadKey();
                continue;
            }
        } while (user == null);
        AnsiConsole.MarkupLine($"[green]{message}[/]");
        _ = ReadKey();
        return "";
    }
}
