using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Helpers;
using Almacen.Models.AutoGen;

namespace UI.Menu;

public class RequestMenu : IView
{
    public const string CreateRequest = "Create Request", ViewRequest = "View Request",
    UpdateRequest = "Update Request", DeleteRequest = "Delete Request", Back = "Back", Exit = "Exit";
    User user;

    public RequestMenu(User user)
    {
        this.user = user;
    }

    public string GetOption()
    {
        switch (UserTypeHelper.GetUserType(user))
        {
            case UserType.Student:
                Request_User_Menu();
                break;
            case UserType.Teacher:
                Request_User_Menu();
                break;
            case UserType.Admin:
                /*Request_Admin_Menu() */
                break;
            case UserType.StoreKeeper:
                /* Request_Admin_Menu() */
                break;
        };

        return AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(6)
                .AddChoices(new[] {
                    CreateRequest, ViewRequest, UpdateRequest, DeleteRequest, Back, Exit
        }));
    }

    private void doNothing()
    {
        throw new NotImplementedException();
    }

    public const string StudentRequest = "Student Request", TeacherRequest = "Teacher Request";
    public static void Request_User_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(4)
                .AddChoices(new[] {
                    StudentRequest, TeacherRequest, Back, Exit
        }));
        switch (userSelection)
        {
            case StudentRequest:
                // Request_General_Menu();
                break;
            case TeacherRequest:
                Request_Teacher_Menu();
                break;
            case Back:

                break;
            case Exit:
                Environment.Exit(0);
                break;
        }
    }


    public const string SimpleRequest = "Simple Request", MultipleSesRequest = "Multiple Sesion Menu";
    public static void Request_Teacher_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(4)
                .AddChoices(new[] {
                    SimpleRequest, MultipleSesRequest, Back, Exit
        }));
        switch (userSelection)
        {
            case SimpleRequest:
                // SimpleRequest();
                break;
            case MultipleSesRequest:
                // MultipleSesRequest();
                break;
            case Back:
                Request_User_Menu(); //EN CASO DE SER ADMIN O STOREKEEPER
                break;
            case Exit:
                Environment.Exit(0);
                break;
        }
    }


    public void DoOption(string option)
    {
        switch (option)
        {
            case CreateRequest:
                // CreateRequest();
                break;
            case ViewRequest:
                // ViewRequest();
                break;
            case UpdateRequest:
                // UpdateRequest();
                break;
            case DeleteRequest:
                // DeleteRequest();
                break;
            case Back:

                break;
            case Exit:
                Environment.Exit(0);
                break;
        }
    }
}
