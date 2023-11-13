
namespace UI.Login;

public class SignIn : Login
{
    public static void Sign_In()
    {
        
        do
        {
            Clear();
            AnsiConsole.Markup("[blue]Sign In[/]\n");
            var typeOfUser = SelectUser();
            var user = AnsiConsole.Ask<string>("Enter your user name:");
            var password = AnsiConsole.Ask<string>("Enter your password:");
            
        } while (true);
    }    
}