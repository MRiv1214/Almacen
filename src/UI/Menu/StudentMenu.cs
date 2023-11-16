using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Menu;

public class StudentMenu : IView
{
    public const string Request = "Create Request", ChangePassword = "Change Password", Exit = "Exit";

    public string GetOption()
    {
        var userSelection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(2)
                .AddChoices(new[] {
                    Request, ChangePassword, Exit
                    }));
        return userSelection;
    }

    public void DoOption(string option)
    {
        switch (option) {
        case Request:
            ViewManager.Next(new RequestMenu());
            break;
        case ChangePassword:
            // TODO: Implement ChangePassword
            // ChangePassword();
            break;
        case Exit:
            Environment.Exit(0);
            break;
        }
    }

}
