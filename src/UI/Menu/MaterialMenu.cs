using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Menu;

public class MaterialMenu : View
{
    public const string CreateMaterial = "Create Material", ViewMaterial = "View Material",
    UpdateMaterial = "Update Material", DeleteMaterial = "Delete Material", Back = "Back", Exit = "Exit";
    public static void Material_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(6)
                .AddChoices(new[] {
                    CreateMaterial, ViewMaterial, UpdateMaterial, DeleteMaterial, Back, Exit
        }));
        switch (userSelection)
        {
            case CreateMaterial:
                // CreateMaterial();
                break;
            case ViewMaterial:
                // ViewMaterial();
                break;
            case UpdateMaterial:
                // UpdateMaterial();
                break;
            case DeleteMaterial:
                // DeleteMaterial();
                break;
            case Back:
                break;
                //Back
            case Exit:
                Environment.Exit(0);
                break;
        }
    }

    
}
