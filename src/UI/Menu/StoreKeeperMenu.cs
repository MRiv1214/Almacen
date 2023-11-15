using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Menu;
public class StoreKeeper
{
    public const string Request = "Request", Material = "Material", 
    MaterialMaintenance = "Material Maintenance", ChangePassword = "Change Password", Exit = "Exit";
    public static void StoreKeeper_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(4)
                .AddChoices(new[] {
                    Request, Material, MaterialMaintenance, ChangePassword, Exit
        }));
        switch (userSelection)
        {
            case Request:
                RequestMenu.Request_User_Menu();
                break;
            case Material:
                MaterialMenu.Material_Menu();
                break;
            case MaterialMaintenance:
                MaterialMaintenanceMenu.MaterialMaintenance_Menu();
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