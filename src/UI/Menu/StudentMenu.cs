using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Menu;
public class StudentMenu
{
    public const string Request = "Create Request", ChangePassword = "Change Password", Exit = "Exit";
    public static void Student_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(2)
                .AddChoices(new[] {
                    Request, ChangePassword, Exit
        }));
        switch (userSelection)
        {
            case Request:
                RequestMenu.Request_General_Menu();
                break;
            case ChangePassword:
                // ChangePassword();
                break;
            case Exit:
                Environment.Exit(0);
                break;
        }
    }    
}