using Almacen.Helpers;
using Almacen.Models.AutoGen;
using Almacen.Repository.Sqlite;
using src.Controllers;
using UI.Menu;

namespace UI.Login;

public class SignIn : IView
{
    

    public void DoOption(string option)
    {
    }

    public string GetOption()
    {
        User? user;
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

            // (user, message) = logInController.LogIn(username, passwordRequest);
            // if (user == null) {
            //     AnsiConsole.MarkupLine($"[red]{message}[/]");
            //     AnsiConsole.MarkupLine("[red]Press any key to continue...[/]");
            //     ReadKey();
            //     continue;
            // }
            //

        } while (true);
        AnsiConsole.MarkupLine($"[green]{message}[/]");
        ReadKey();
        return "";
    }
}
