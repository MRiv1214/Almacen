using Almacen.Helpers;
using Almacen.Models.AutoGen;
using Almacen.Repository.Sqlite;
using src.Controllers;

namespace UI.Login;

public class SignIn
{
    public static void Sign_In()
    {
        var userRepository = new SqliteRepository<User>(AlmacenContext.GetInstance());
        var logInController = new LogInController(userRepository);
        do
        {
            Clear();
            AnsiConsole.Markup("[blue]Sign In[/]\n");
            var username = AnsiConsole.Ask<string>("Enter your user name:");
            var passwordRequest = SHA256Password.Encrypt(
                AnsiConsole.Prompt(
                    new TextPrompt<string>("Enter your password:")
                        .PromptStyle("gray")
                        .Secret()));
                            
            var (user, error) = logInController.LogIn(username, passwordRequest);
            if (user == null)
            {
                AnsiConsole.MarkupLine($"[red]{error}[/]");
                AnsiConsole.MarkupLine("[red]Press any key to continue...[/]");
                ReadKey();
                continue;
            }
            AnsiConsole.MarkupLine($"[green]{error}[/]");
            ReadKey();
            
        } while (true);
    }    
}