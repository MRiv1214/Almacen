using Almacen.Controllers;
using Almacen.Models.Dtos;
using Almacen.Helpers;
using Almacen.Repository;
using Almacen.Models.AutoGen;
using Almacen.Repository.Sqlite;
using Almacen.UI.Forms;
namespace UI.Login;


public class SignUp : Login
{
    //Console Sign Up
    public static void Sign_Up()
    {
        
        // login with user and password to create new user
        UserForm.CreateUserForm();
        AnsiConsole.Markup("[blue]Sign Up[/]\n");
        var typeOfUser = SelectUser();
        switch (typeOfUser)
        {
            case gStoreKeeper:
                
                break;
            case gTeacher:
                
                break;
            case gStudent:
                
                break;
            case gAdmin:
                
                break;
            case exit:
                Environment.Exit(0);
                break;
        }
    }
    
}