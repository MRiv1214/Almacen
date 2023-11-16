using Almacen.Helpers;
using Almacen.Models.AutoGen;
using Almacen.Repository.Sqlite;
using SQLitePCL;
using src.Controllers;
using UI.Menu;

namespace UI.Login;

public class SignIn : IView
{
    private SignInController signInController;
    private User? user = null;

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

            (user, message) = signInController.LogIn(username, passwordRequest);
            if (user == null) {
                AnsiConsole.MarkupLine($"[red]{message}[/]");
                AnsiConsole.MarkupLine("[red]Press any key to continue...[/]");
                _ = ReadKey();
                continue;
            }
        } while (user == null);
        AnsiConsole.MarkupLine($"[green]{message}[/]");
        _ = ReadKey();
        return "ok";
    }

    public void DoOption(string option)
    {
        switch (UserTypeHelper.GetUserType(user!))  {
            case UserType.Admin:
                ViewManager.Next(new AdminMenu());
                break;
            case UserType.StoreKeeper:
                ViewManager.Next(new StoreKeeperMenu());
                break;
            case UserType.Teacher:
                ViewManager.Next(new TeacherMenu());
                break;
            case UserType.Student:
                ViewManager.Next(new StudentMenu());
                break;
        }
    }
}
