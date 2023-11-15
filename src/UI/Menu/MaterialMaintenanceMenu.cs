using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Menu;

public class MaterialMaintenanceMenu : IView
{
    public const string CreateMaintenance = "Create Material Maintenance", ViewMaintenance = "View Material Maintenance",
    UpdateMaintenance = "Update Material Maintenance", DeleteMaintenance = "Delete Material Maintenance", Back = "Back", Exit = "Exit";
    public static void MaterialMaintenance_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(6)
                .AddChoices(new[] {
                    CreateMaintenance, ViewMaintenance, UpdateMaintenance, DeleteMaintenance, Back, Exit
        }));
        switch (userSelection)
        {
            case CreateMaintenance:
                // CreateMaintenance();
                break;
            case ViewMaintenance:
                // ViewMaintenance();
                break;
            case UpdateMaintenance:
                // UpdateMaintenance();
                break;
            case DeleteMaintenance:
                // DeleteMaintenance();
                break;
            case Back:
                break;
            //Back
            case Exit:
                Environment.Exit(0);
                break;
        }
    }

    public void DoOption(string option)
    {
        throw new NotImplementedException();
    }

    public string GetOption()
    {
        throw new NotImplementedException();
    }
}
