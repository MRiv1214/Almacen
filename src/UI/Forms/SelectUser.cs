using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Login;
using Almacen.Helpers;

namespace UI.Forms;

public class SelectUser : View
{
    public const string gStoreKeeper = "StoreKeeper", gTeacher = "Teacher", gStudent = "Student", gAdmin = "Admin";
    
    public static UserType SelectUserForm()
    {
        Clear();
        var typeOfUser = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select your type of user")
                .PageSize(4)
                .AddChoices(new[] {
                    gAdmin, gStoreKeeper, gTeacher, gStudent
        }));
        // select type of user
        UserType userType = typeOfUser switch
        {
            gAdmin => UserType.Admin,
            gStoreKeeper => UserType.StoreKeeper,
            gTeacher => UserType.Teacher,
            gStudent => UserType.Student,
            _ => throw new ArgumentException("Invalid type of user")
        };
        return userType;
    }
}
        

